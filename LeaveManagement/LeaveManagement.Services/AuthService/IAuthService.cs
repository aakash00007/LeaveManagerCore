using LeaveManagement.Data.Models.DtoModels;
using LeaveManagement.Data.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.AuthService
{
    public interface IAuthService
    {
        Task<LoginResponse> LoginUser(UserLoginDto loginDto);
    }
}
