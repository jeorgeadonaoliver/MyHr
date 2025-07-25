﻿

namespace myHr.application.Features.LeaveCredits.command.update_leavecredit;

public static class UpdateLeaveCreditCommandExtenstion
{
    public static LeaveCredit MapToLeaveCredit(this UpdateLeaveCreditCommand cmd) 
    {
        return new LeaveCredit 
        {
            CreditId = cmd.Id,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            EmployeeId = cmd.EmployeeId,
            LeaveType = cmd.LeaveType,
            ModifiedBy = cmd.ModifiedBy,
            ModifiedDate = cmd.ModifiedDate,
            RemainingCredits = cmd.RemainingCredits,
            TotalCredits = cmd.TotalCredits,
            UsedCredits = cmd.UsedCredits
        };
    }
}
