
namespace myHr.application.Features.LeaveCredits.query.get_all_leavecredits;

public class GetAllLeaveCreditQueryDto : BaseDto
{
    public Guid? EmployeeId { get; set; }

    public string LeaveType { get; set; } = null!;

    public int TotalCredits { get; set; }

    public int? UsedCredits { get; set; }

    public int? RemainingCredits { get; set; }

}
