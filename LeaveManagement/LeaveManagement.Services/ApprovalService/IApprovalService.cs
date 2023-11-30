using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Services.ApprovalService
{
    public interface IApprovalService
    {
        Task<bool> IsActionTakenByLowerPriority(int leaveRequestId, int currPriority);

    }
}
