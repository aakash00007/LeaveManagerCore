using EmailService;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.DtoModels;
using LeaveManagement.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;
        public AuthenticationController(IAuthService authService, IEmailSender emailSender,UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _authService = authService;
            _emailSender = emailSender;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var result = await _authService.LoginUser(loginDto);
                    if(result.Success ==  true)
                    {
                        return Ok(result);
                    }
                    return Unauthorized();
                }
                catch (Exception ex)
                {
                    return StatusCode(500);
                }
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDto forgetPasswordDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User user = await _userManager.FindByEmailAsync(forgetPasswordDto.Email);
                    if (user == null)
                    {
                        return NotFound("No User found with the provided Email.");
                    }
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var callback = Url.Action("ResetPassword", "Authentication", new { token, email = forgetPasswordDto.Email }, "http", "localhost:5211");
                    callback = callback.Replace("/api", "");
                    Message message = new Message(user.Email, "Reset Password Token", callback);
                    await _emailSender.SendEmail(message);
                    return Ok("Mail Send Successfully " + token);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
                    if (user != null)
                    {
                        var result = await _userManager.ResetPasswordAsync(user, resetPasswordDto.Token, resetPasswordDto.Password);
                        if (result.Succeeded)
                        {
                            return Ok("Password reset Successfully");
                        }
                        return BadRequest();
                    }
                    return NotFound("User Doesn't Exist!");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> SetPassword(SetPasswordDto setPasswordDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByEmailAsync(setPasswordDto.Email);
                    if (user != null)
                    {
                        var result = await _userManager.ResetPasswordAsync(user, setPasswordDto.Token, setPasswordDto.Password);
                        if (result.Succeeded)
                        {
                            return Ok("Password Set Successfully");
                        }
                        return BadRequest();
                    }
                    return NotFound("User Doesn't Exist!");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            return BadRequest();
        }
    }
}
