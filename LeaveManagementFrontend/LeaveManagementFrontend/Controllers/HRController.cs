using LeaveManagementFrontend.Models.DtoModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace LeaveManagementFrontend.Controllers
{
    [Authorize(Roles = "HR")]
    public class HRController : Controller
    {
        private readonly HttpClient _httpClient;
        Uri baseAddress = new Uri("http://localhost:5264/api");

        public HRController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = baseAddress;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
         {
            var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
            HttpResponseMessage response = await _httpClient.GetAsync(baseAddress + "/HR/GetAllUsers");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<UserDto> userList = JsonConvert.DeserializeObject<List<UserDto>>(data);
                RegisterAndUserCombineDto registerAndUserCombineDto = new RegisterAndUserCombineDto();
                registerAndUserCombineDto.UserDto = userList;
                registerAndUserCombineDto.UserRegisterationDto = new UserRegisterationDto();
                registerAndUserCombineDto.UserRegisterationDto.Roles = await GetAllRoles();

                ViewData["Error"] = null;
                return View(registerAndUserCombineDto);
            }
            ViewData["Error"] = "No User Found!";
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> RegisterUser(UserRegisterationDto userRegisterationDto)
        {
            userRegisterationDto.Roles = await GetAllRoles();
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            try
            {
                string data = JsonConvert.SerializeObject(userRegisterationDto);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
                HttpResponseMessage response = await _httpClient.PostAsync(baseAddress + "/HR/RegisterUser", content);
                if(response.IsSuccessStatusCode)
                {
                    var token = await response.Content.ReadAsStringAsync();

                    TempData["Success"] = "User Registered Successfully";
                    return RedirectToAction(nameof(RegisterConfirmation));
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult RegisterConfirmation()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
            HttpResponseMessage response = await _httpClient.GetAsync(baseAddress + "/HR/GetUserById/" + id);
            if(response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                UserRoleCombineDto combineDto = JsonConvert.DeserializeObject<UserRoleCombineDto>(data);
                UserRegisterationDto foundUser = new UserRegisterationDto();
                foundUser.Id = combineDto.User.Id;
                foundUser.Name = combineDto.User.Name;
                foundUser.Email = combineDto.User.Email;
                foundUser.UserName = combineDto.User.UserName;
                foundUser.Role = combineDto.Role;
                return Json(foundUser);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserRegisterationDto userRegisterationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                userRegisterationDto.Roles = await GetAllRoles();
                string data = JsonConvert.SerializeObject(userRegisterationDto);
                StringContent content = new StringContent(data,Encoding.UTF8, "application/json");
                var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
                HttpResponseMessage response = await _httpClient.PutAsync(baseAddress + "/HR/EditUser/" + userRegisterationDto.Id,content);
                if(response.IsSuccessStatusCode)
                {
                    TempData["Success"] = "User Updated Successfully";
                    return RedirectToAction("Index");
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Internal Server Error";
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUser(string id)
        {
            try
            {
                var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
                HttpResponseMessage response = await _httpClient.DeleteAsync(baseAddress + "/HR/DeleteUser/" + id);
                if (response.IsSuccessStatusCode)
                {
                    ViewData["Success"] = "User Removed Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewData["Error"] = "Something went wrong. Please try later!!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "Internal Server Error While Deleting. Please try later";
                return RedirectToAction("Index");
            }
        }

        private async Task<List<string>> GetAllRoles()
        {
            var accessTokenFromSession = HttpContext.Session.GetString("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessTokenFromSession);
            HttpResponseMessage response = await _httpClient.GetAsync(baseAddress + "/HR/GetAllRoles");
            if(response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                List<string> roleList = JsonConvert.DeserializeObject<List<string>>(data);
                return roleList;
            }
            return new List<string>();
        }
    }
}
