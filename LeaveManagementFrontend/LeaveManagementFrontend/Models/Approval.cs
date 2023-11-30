namespace LeaveManagementFrontend.Models
{
    public class Approval
    {
        public int ApprovalId { get; set; }
        public string? UserId { get; set; }
        public int? LeaveRequestId { get; set; }
        public string ApprovalReason { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
        public int Priority { get; set; }
        public virtual LeaveRequest? LeaveRequest { get; set; }
        public virtual User? User { get; set; }
        

    }

    public enum ApprovalStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}
