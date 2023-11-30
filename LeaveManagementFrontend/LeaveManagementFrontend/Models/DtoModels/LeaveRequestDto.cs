using System.ComponentModel.DataAnnotations;

namespace LeaveManagementFrontend.Models.DtoModels
{
    public class LeaveRequestDto
    {
        public int LeaveRequestId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime From { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string? Name { get; set; }
        public DateTime To { get; set; }
        public string Reason { get; set; }
        public int? Priority { get; set; }
        public string? UserId { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
        public virtual List<Approval>? Approvals { get; set; }
    }
}
