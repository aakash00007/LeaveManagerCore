using LeaveManagement.Data.DBContext;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.DtoModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.HRService
{
    public class HRService : IHRService
    {
        private readonly IConfiguration _configuration;
        private readonly LeaveContext _context;

        public HRService(IConfiguration configuration,LeaveContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<List<UserRoleCombineDto>> GetUserRoleList()
        {
            var userRoleList = (from user in _context.Users
                                join userrole in _context.UserRoles on user.Id equals userrole.UserId
                                join roles in _context.Roles on userrole.RoleId equals roles.Id
                                select new UserRoleCombineDto { User = user,Role = roles.Name}).ToList();
            return userRoleList;
        }

        public async Task<UserRoleCombineDto> GetUserById(string id)
        {
            var foundUser = (from user in _context.Users
                        join userrole in _context.UserRoles on user.Id equals userrole.UserId
                        join roles in _context.Roles on userrole.RoleId equals roles.Id
                        select new UserRoleCombineDto { User = user, Role = roles.Name }).Where(x=> x.User.Id == id).FirstOrDefault();
            return foundUser;
        }
    }
}
