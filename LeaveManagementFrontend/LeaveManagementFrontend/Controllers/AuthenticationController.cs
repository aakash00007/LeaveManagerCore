using LeaveManagementFrontend.Models;
using LeaveManagementFrontend.Models.DtoModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LeaveManagementFrontend.Controllers
{
    public class AuthenticationController : Controller
    {
        private HttpClient _httpClient;
        Uri baseAddress = new Uri("http://localhost:5264/api");

        public AuthenticationController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string data = JsonConvert.SerializeObject(userLoginDto);
                StringContent content = new StringContent(data,Encoding.UTF8,"application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/Authentication/Login" , content);
                if(response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();
                    TokenConfig accessToken = JsonConvert.DeserializeObject<TokenConfig>(token);
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = (JwtSecurityToken)tokenHandler.ReadToken(accessToken.Token);
                    var claimsIdentity = new ClaimsIdentity(securityToken.Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                    string role = securityToken.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
                    HttpContext.Session.SetString("AccessToken", accessToken.Token);
                    TempData["Success"] = "User SignedIn Successfully";
                    if(role == "HR")
                    {
                        return RedirectToAction("Index","HR");   
                    }
                    return RedirectToAction("Index","User");
                }
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("","Internal Server Error");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                TempData["Success"] = "Logged Out Successfully!!";
                HttpContext.Session.Clear();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string data = JsonConvert.SerializeObject(forgotPasswordDto);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/Authentication/ForgotPassword", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(ForgotPasswordConfirmation));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Internal Server Error. Please try after some time!!");
                return View();
            }
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            ResetPasswordDto resetPasswordDto = new ResetPasswordDto { Token = token, Email = email };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string data = JsonConvert.SerializeObject(resetPasswordDto);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/Authentication/ResetPassword", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(ResetPasswordConfirmation));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Internal Server Error. Please try after some time!!");
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SetPassword(string token,string email)
        {
            SetPasswordDto setPasswordDto = new SetPasswordDto { Token = token, Email = email };
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SetPassword(SetPasswordDto setPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                string data = JsonConvert.SerializeObject(setPasswordDto);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/Authentication/SetPassword", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(SetPasswordConfirmation));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Internal Server Error. Please try after some time!!");
                return View();
            }
            return View();
        }

        [HttpGet]
        public IActionResult SetPasswordConfirmation()
        {
            return View();
        }

    }
}
