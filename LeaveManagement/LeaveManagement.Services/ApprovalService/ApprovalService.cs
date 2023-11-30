using LeaveManagement.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.ApprovalService
{
    public class ApprovalService : IApprovalService
    {
        private readonly LeaveContext _context;
        public ApprovalService(LeaveContext context)
        {
            _context = context;
        }

        public async Task<bool> IsActionTakenByLowerPriority(int leaveRequestId, int currPriority)
        {
            var leave = await _context.Approvals.Where(x => x.LeaveRequestId == leaveRequestId && x.Priority == currPriority - 1).ToListAsync();
            if (leave.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
