using myHr.application.Features.LeaveCredits.query.get_leavecredit.by_id;

namespace myHr.application.Extension;

public static class LeaveCreditExtension
{
    public static GetAllLeaveCreditQueryDto MapToGetAllLeaveCreditQueryDto(this LeaveCredit lc) 
    {
        return new GetAllLeaveCreditQueryDto { 
        
            CreatedBy = lc.CreatedBy,
            CreatedDate = lc.CreatedDate,
            EmployeeId = lc.EmployeeId,
            Id = lc.CreditId,
            LeaveType = lc.LeaveType,
            ModifiedBy = lc.ModifiedBy,
            ModifiedDate = lc.ModifiedDate,
            RemainingCredits = lc.RemainingCredits,
            TotalCredits = lc.TotalCredits,
            UsedCredits = lc.UsedCredits,

        };
    }

    public static GetLeaveCreditByIdQueryDto MapToGetLeaveCreditByIdQueryDto(this LeaveCredit lc)
    {
        return new GetLeaveCreditByIdQueryDto
        {

            CreatedBy = lc.CreatedBy,
            CreatedDate = lc.CreatedDate,
            EmployeeId = lc.EmployeeId,
            Id = lc.CreditId,
            LeaveType = lc.LeaveType,
            ModifiedBy = lc.ModifiedBy,
            ModifiedDate = lc.ModifiedDate,
            RemainingCredits = lc.RemainingCredits,
            TotalCredits = lc.TotalCredits,
            UsedCredits = lc.UsedCredits,

        };
    }
}
