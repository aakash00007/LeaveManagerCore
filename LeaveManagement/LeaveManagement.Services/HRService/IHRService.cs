using LeaveManagement.Data.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.HRService
{
    public interface IHRService
    {
        Task<List<UserRoleCombineDto>> GetUserRoleList();
        Task<UserRoleCombineDto> GetUserById(string id);
    }
}
