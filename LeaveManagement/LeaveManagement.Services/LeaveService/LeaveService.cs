using LeaveManagement.Data.DBContext;
using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.ResponseModels;
using LeaveManagement.Services.HRService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.LeaveService
{
    public class LeaveService : ILeaveService
    {
        private readonly IConfiguration _configuration;
        private readonly LeaveContext _context;
        public LeaveService(IConfiguration configuration,LeaveContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<IEnumerable<LeaveRequest>> GetLeavesByPriority(int userPriority)
        {
            var leavesByPriority = _context.LeaveRequests.Where(l => l.Priority < userPriority).ToList();
            return leavesByPriority;
        }

        public async Task<IEnumerable<LeaveRequest>> GetLeavesByUserId(string userId)
        {
            var leavesByUserId = _context.LeaveRequests.Where(l => l.UserId == userId).ToList();
            return leavesByUserId;
        }

        public async Task<string> GetLeaveRoleByLeaveRequestId(int leaveRequestId)
        {
            var role = (from leaverequest in _context.LeaveRequests
                         join user in _context.Users on leaverequest.UserId equals user.Id
                         join userrole in _context.UserRoles on user.Id equals userrole.UserId
                         join roles in _context.Roles on userrole.RoleId equals roles.Id
                         where leaverequest.LeaveRequestId == leaveRequestId
                         select roles.Name).ToList();
            return role[0];
        }
    }
}
