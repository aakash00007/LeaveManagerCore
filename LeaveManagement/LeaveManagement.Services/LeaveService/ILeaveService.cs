using LeaveManagement.Data.Models;
using LeaveManagement.Data.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.LeaveService
{
    public interface ILeaveService
    {
        Task<IEnumerable<LeaveRequest>> GetLeavesByPriority(int priority);
        Task<IEnumerable<LeaveRequest>> GetLeavesByUserId(string userId);
        Task<string> GetLeaveRoleByLeaveRequestId(int leaveRequestId);
    }
}
