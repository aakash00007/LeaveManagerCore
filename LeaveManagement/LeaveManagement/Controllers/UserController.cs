using AutoMapper;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.DtoModels;
using LeaveManagement.Data.Models.ResponseModels;
using LeaveManagement.Data.Repository;
using LeaveManagement.Services.ApprovalService;
using LeaveManagement.Services.LeaveService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<LeaveRequest> _genericLeaveRepository;
        private readonly ILeaveService _leaveService; 
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;
        private readonly LeaveFlow _leaveFlow;
        private readonly IGenericRepository<Approval> _approvalRepository;
        private readonly IApprovalService _approvalService;

        public UserController(IGenericRepository<LeaveRequest> genericLeaveRepository,IMapper mapper,ILeaveService leaveService,IHttpContextAccessor httpContext,LeaveFlow leaveFlow,IGenericRepository<Approval> approvalRepository,IApprovalService approvalService)
        {
            _genericLeaveRepository = genericLeaveRepository;
            _leaveService = leaveService;
            this._httpContext = httpContext;
            _leaveFlow = leaveFlow;
            _mapper = mapper;
            _approvalRepository = approvalRepository;
            _approvalService = approvalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequests()
        {
            try
            {
                var leaveRequests = _genericLeaveRepository.GetAll().Result.ToList();
                if(leaveRequests ==  null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(leaveRequests);
                }
            }
            catch 
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLeaveRequestById(int id)
        {
            try
            {
                var leaveRequest = await _genericLeaveRepository.GetById(id);
                if(leaveRequest == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(leaveRequest);
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateLeaveRequest([FromBody] LeaveRequestDto leaveRequestDto)
        {
            try
            {
                var leaveRequest = _mapper.Map<LeaveRequest>(leaveRequestDto);
                await _genericLeaveRepository.Insert(leaveRequest);
                await _genericLeaveRepository.Save();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLeavesByUserId()
        {
            try
            {
                var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToString();
                var leavesByUserId = await _leaveService.GetLeavesByUserId(userId);
                return Ok(leavesByUserId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLeavesByPriority()
        {
            try
            {
                var priority = GetUserPriority();
                var leavesByPriority = await _leaveService.GetLeavesByPriority(priority);
                return Ok(leavesByPriority);
            }
            catch(Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> ApproveRejectLeave([FromBody] ApprovalDto approvalDto)
        {
            try
            {
                var role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToString();
                var currentPriority = GetUserPriority();
                bool canTakeAction = await CanTakeAction(currentPriority,approvalDto.LeaveRequestId);
                if(!canTakeAction) 
                {
                    return StatusCode(500, "Descision not made by previous authority.");
                }
                string leaveRole = await _leaveService.GetLeaveRoleByLeaveRequestId(approvalDto.LeaveRequestId);
                var approval = _mapper.Map<Approval>(approvalDto);
                approval.UserId = userId;
                approval.Priority = currentPriority;
                await _approvalRepository.Insert(approval);
                await _approvalRepository.Save();
                if(approval.Priority == _leaveFlow.Levels[_leaveFlow.Levels.Count-1].Priority)
                {
                    LeaveRequest foundRequest = _genericLeaveRepository.GetById(approvalDto.LeaveRequestId).Result;
                    if(foundRequest != null)
                    {
                        foundRequest.ApprovalStatus = approval.ApprovalStatus;
                        _genericLeaveRepository.Update(foundRequest);
                        await _genericLeaveRepository.Save();   
                    }
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        private async Task<bool> CanTakeAction(int currPriority,int leaveRequestId)
        {
            var leave =  _genericLeaveRepository.GetById(leaveRequestId).Result;
            if(leave != null)
            {
                if(leave.Priority == currPriority - 1)
                {
                    return true;
                }
                else
                {
                    var foundApprovedLeave = await _approvalService.IsActionTakenByLowerPriority(leaveRequestId, currPriority);
                    if (foundApprovedLeave)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        private int GetUserPriority()
        {
            var role = _httpContext.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
            var flow = _leaveFlow.Levels.ToList();
            var priority = 0;
            foreach (var level in flow)
            {
                if(level.Role == role)
                {
                    priority = level.Priority;
                }
            }
            return priority;
        }

    }
}
