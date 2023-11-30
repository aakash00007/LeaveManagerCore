namespace LeaveManagementFrontend.Models.DtoModels
{
    public class ApprovalLeaveRequestDto
    {
        public virtual Approval Approval { get; set; }
        public virtual List<LeaveRequest> LeaveRequest { get; set; }
    }
}
