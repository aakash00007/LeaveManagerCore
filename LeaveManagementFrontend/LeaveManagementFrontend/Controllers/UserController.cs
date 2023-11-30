using LeaveManagementFrontend.Models;
using LeaveManagementFrontend.Models.DtoModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;

namespace LeaveManagementFrontend.Controllers
{
    public class UserController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:5264/api");
        private readonly HttpClient _httpClient;
        private readonly LeaveFlow _leaveFlow;

        public UserController(HttpClient httpClient, LeaveFlow leaveFlow)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
            _leaveFlow = leaveFlow;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
            HttpResponseMessage response = await _httpClient.GetAsync(baseAddress + "/User/GetLeavesByUserId");
            if(response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var myLeaves = JsonConvert.DeserializeObject<List<LeaveRequest>>(data);
                ViewData["Error"] = null;
                return View(myLeaves);
            }
            ViewData["Error"] = "No Leave Requests to show!";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetLeavesByPriority()
        {
            var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
            HttpResponseMessage response = await _httpClient.GetAsync(baseAddress + "/User/GetLeavesByPriority");
            if (response.IsSuccessStatusCode)
            {
                var priority = GetUserPriority();
                ViewBag.priority = priority;
                ViewBag.flow = _leaveFlow;
                var data = await response.Content.ReadAsStringAsync();
                List<LeaveRequest> leavesByPriority = JsonConvert.DeserializeObject<List<LeaveRequest>>(data);
                //ApprovalLeaveRequestDto approvalLeaveRequestDto = new ApprovalLeaveRequestDto();
                //approvalLeaveRequestDto.LeaveRequest = leavesByPriority;
                ViewData["Error"] = null;
                return View(leavesByPriority);
            }
            ViewData["Error"] = "No Leave Requests to show!";
            return View();
        }

        [HttpGet]
        public IActionResult ApplyLeave()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApplyLeave(LeaveRequestDto leaveRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
                
                string userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToString();
                var priority = GetUserPriority();
                leaveRequestDto.UserId = userId;
                leaveRequestDto.Priority = priority;
                string data = JsonConvert.SerializeObject(leaveRequestDto);
                StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/User/CreateLeaveRequest", content);
                if (response.IsSuccessStatusCode)
                {
                    ViewData["Success"] = "Leave Applied Successfully";
                    return RedirectToAction("Index");
                }                       
            }
            catch (Exception ex) 
            {
                ViewData["Error"] = "Internal Server Error. Please try later!!";
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApproveRejectLeave(ApprovalDto approvalDto)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("GetLeavesByPriority");
            }
            try
            {
                string data = JsonConvert.SerializeObject(approvalDto);
                StringContent content = new StringContent(data, Encoding.UTF8,"application/json");
                var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/User/ApproveRejectLeave", content);
                if (response.IsSuccessStatusCode)
                {
                    if(approvalDto.ApprovalStatus == ApprovalStatus.Accepted)
                    {
                        TempData["Success"] = "Leave Approved Successfully";
                        return RedirectToAction("GetLeavesByPriority");
                    }
                    else
                    {
                        TempData["Success"] = "Leave Rejected Successfully";
                        return RedirectToAction("GetLeavesByPriority");
                    } 
                }
                TempData["Error"] = "Can't Take Action, Leave Not Approved By Previous Authority";
                return RedirectToAction("GetLeavesByPriority");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private int GetUserPriority()
        {
            var role = HttpContext.User.FindFirst(ClaimTypes.Role)?.Value.ToString();
            var flow = _leaveFlow.Levels.ToList();
            var priority = 0;
            foreach (var level in flow)
            {
                if (level.Role == role)
                {
                    priority = level.Priority;
                    break;
                }
            }
            return priority;
        }
    }
}
