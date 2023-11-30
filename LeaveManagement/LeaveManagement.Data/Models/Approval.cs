using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models
{
    public class Approval
    {
        public int ApprovalId { get; set; } 
        public string? UserId { get; set; }
        public int? LeaveRequestId { get; set; }
        public string ApprovalReason { get; set; }
        public int Priority { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
        public virtual LeaveRequest? LeaveRequest { get; set; }
        public virtual User? User { get; set; }

    }

    public enum ApprovalStatus {
        Pending,
        Accepted,
        Rejected
    }
}
