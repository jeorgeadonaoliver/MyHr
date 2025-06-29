namespace myHr.application.Features.LeaveCredits.command.update_leavecredit;

public class UpdateLeaveCreditCommand : BaseDto, IRequest<Result<Guid>>
{
    public Guid? EmployeeId { get; set; }

    public string LeaveType { get; set; } = null!;

    public int TotalCredits { get; set; }

    public int? UsedCredits { get; set; } = 0;

    public int? RemainingCredits { get; set; } = 0;

}
