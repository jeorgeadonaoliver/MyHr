
namespace myHr.application.Features.LeaveRequests.query.get_leaverequest.by_leaverequest_id;

public class GetLeaveRequestByIdQueryDto : BaseDto
{
    public Guid? EmployeeId { get; set; }

    public Guid? CreditId { get; set; }

    public string LeaveType { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Status { get; set; }
}
