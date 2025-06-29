

namespace myHr.application.Features.LeaveCredits.command.create_leavecredit;

public static class CreateLeaveCreditCommandExtension
{
    public static LeaveCredit MapToLeaveCredit(this CreateLeaveCreditCommand cmd)
    {
        return new LeaveCredit { 
            CreditId = cmd.Id,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            EmployeeId = cmd.EmployeeId,
            LeaveType = cmd.LeaveType,
            RemainingCredits = cmd.RemainingCredits,
            TotalCredits = cmd.TotalCredits,
            UsedCredits = cmd.UsedCredits
        };
    }
}
