using AutoMapper;
using EmailService;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.DtoModels;
using LeaveManagement.Data.Repository;
using LeaveManagement.Services.HRService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer",Roles = "HR")]
    public class HRController : ControllerBase
    {
        private readonly IGenericRepository<User> _userGenericRepository;
        private readonly IGenericRepository<IdentityRole> _identityRoleGenericRepository;
        private readonly IGenericRepository<UserRoleCombineDto> _userRoleCombineRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        public readonly IHRService _hRService;
        public HRController(IGenericRepository<User> userGenericRepository, UserManager<User> userManager,IMapper mapper, IEmailSender emailSender,IGenericRepository<IdentityRole> identityGenericRepository,IHRService hRService,IGenericRepository<UserRoleCombineDto> userRoleCombineRepository)
        {
            _userGenericRepository = userGenericRepository;
            _userManager = userManager;
            _mapper = mapper;
            _emailSender = emailSender;
            _identityRoleGenericRepository = identityGenericRepository;
            _hRService = hRService;
            _userRoleCombineRepository = userRoleCombineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var empList = _hRService.GetUserRoleList().Result.ToList();
                if(empList.Count() == 0)
                {
                    return NotFound("No User Found!");
                }
                return Ok(empList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(string id)
        {
            try
            {
                var foundUser = await _hRService.GetUserById(id);
                if(foundUser == null)
                {
                    return NotFound();
                }
                return Ok(foundUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roleList = _identityRoleGenericRepository.GetAll().Result.ToList();
            if (roleList.Count() == 0)
            {
                return NotFound("No Roles Available.");
            }
            return Ok(roleList.Select(x=>x.Name));
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserRegisterationDto userRegisterationDto)
        {
            try
            {
                var userexist = await _userManager.FindByEmailAsync(userRegisterationDto.Email);
                if (userexist != null)
                {
                    return StatusCode(409, "User Already Exists!");
                }
                var user = _mapper.Map<User>(userRegisterationDto);
                var result = await _userManager.CreateAsync(user); 
                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, userRegisterationDto.Role);
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var callback = Url.Action("SetPassword", "Authentication", new { token, email = userRegisterationDto.Email }, "http", "localhost:5211");
                    callback = callback.Replace("/api", "");
                    Message message = new Message(user.Email, "Set Password Token", callback);
                    await _emailSender.SendEmail(message);
                    return Ok("Mail Send Successfully " + token);
                }
                else
                {
                    return StatusCode(409, "User Already Exists!");
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditUser(string id,UserRegisterationDto userRegisterationDto)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var userExist = await _userGenericRepository.GetById(id);
                    if(userExist == null)
                    {
                        return NotFound("User Not Found");
                    }
                    var user = _mapper.Map(userRegisterationDto,userExist);
                    List<string> roles = _userManager.GetRolesAsync(userExist).Result.ToList();
                    await _userManager.RemoveFromRoleAsync(userExist, roles[0]);
                    await _userManager.AddToRoleAsync(userExist, userRegisterationDto.Role);
                    userExist.NormalizedEmail = userRegisterationDto.Email.ToUpper();
                    _userGenericRepository.Update(userExist);
                    await _userGenericRepository.Save();
                    return Ok();
                }
                catch (Exception ex)
                {
                    return StatusCode(500);
                }
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            User userExist = await _userGenericRepository.GetById(id);
            if (userExist == null)
            {
                return NotFound("User Not Found");
            }
            await _userGenericRepository.Delete(userExist.Id);
            await _userGenericRepository.Save();
            return Ok();
        }

        
    }
}
