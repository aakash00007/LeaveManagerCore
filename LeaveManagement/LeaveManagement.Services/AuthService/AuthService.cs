using AutoMapper;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.DtoModels;
using LeaveManagement.Data.Models.ResponseModels;
using LeaveManagement.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;

        public AuthService(IMapper mapper,UserManager<User> userManager, SignInManager<User> signInManager,IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _config = configuration;
        }

        public async Task<LoginResponse> LoginUser(UserLoginDto loginDto)
        {
            User user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, lockoutOnFailure: false);
                if (!result.Succeeded)
                {
                    return new LoginResponse 
                    {
                        Success = false
                    };
                    
                }
                List<string> roles = _userManager.GetRolesAsync(user).Result.ToList();
                var claims = new[] {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, roles[0]),
                new Claim(ClaimTypes.NameIdentifier,
                user.Id)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                                 _config["Jwt:Audience"],
                                                 claims,
                                                 expires: DateTime.Now.AddDays(1),
                                                 signingCredentials: credentials);
                return new LoginResponse
                {
                    Success = true,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Role = roles[0].ToString(),
                    UserId = user.Id
                };
            }
            return new LoginResponse { Success = false, Message = "Incorrect Password" };
        }

        
    }
}
