namespace myHr.application.Features.LeaveRequests.command.update_leaverequest
{
    public class UpdateLeaveRequestCommand : BaseDto, IRequest<Result<Guid>>
    {
        public Guid? EmployeeId { get; set; }

        public Guid? CreditId { get; set; }

        public string LeaveType { get; set; } = null!;

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public string? Status { get; set; }
    }
}
