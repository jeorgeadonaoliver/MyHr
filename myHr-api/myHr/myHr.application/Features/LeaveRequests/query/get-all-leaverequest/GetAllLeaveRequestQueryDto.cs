
namespace myHr.application.Features.LeaveRequests.query.get_all_leaverequest
{
    public class GetAllLeaveRequestQueryDto : BaseDto
    {
        public Guid? EmployeeId { get; set; }

        public Guid? CreditId { get; set; }

        public string LeaveType { get; set; } = null!;

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public string? Status { get; set; }
    }
}
