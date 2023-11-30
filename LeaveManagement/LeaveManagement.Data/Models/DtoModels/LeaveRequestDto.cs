using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models.DtoModels
{
    public class LeaveRequestDto
    {
        public int LeaveRequestId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Reason { get; set; }
        public int? Priority { get; set; }
        public string UserId { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
    }
}
