using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Reason { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
        public int? Priority { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Approval>? Approvals { get; set; }
    }
}
