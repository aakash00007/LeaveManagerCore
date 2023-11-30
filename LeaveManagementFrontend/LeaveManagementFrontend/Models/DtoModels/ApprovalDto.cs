namespace LeaveManagementFrontend.Models.DtoModels
{
    public class ApprovalDto
    {
        public string? UserId { get; set; }
        public int LeaveRequestId { get; set; }
        public string ApprovalReason { get; set; }
        public int Priority { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Pending;
    }
}
