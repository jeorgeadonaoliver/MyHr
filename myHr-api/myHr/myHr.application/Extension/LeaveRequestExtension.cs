using myHr.application.Features.LeaveRequests.query.get_all_leaverequest;
using myHr.application.Features.LeaveRequests.query.get_leaverequest.by_leaverequest_id;

namespace myHr.application.Extension;

public static class LeaveRequestExtension
{
    public static GetLeaveRequestByEmployeeIdQueryDto MapToGetLeaveRequestByEmployeeIdQueryDto(this LeaveRequest lr) 
    {
        return new GetLeaveRequestByEmployeeIdQueryDto { 
        
            Id = lr.LeaveId,
            CreatedBy = lr.CreatedBy,
            CreatedDate = lr.CreatedDate,
            CreditId = lr.CreditId,
            EmployeeId = lr.EmployeeId,
            EndDate = lr.EndDate,
            LeaveType = lr.LeaveType,
            ModifiedBy = lr.ModifiedBy,
            ModifiedDate = lr.ModifiedDate,
            StartDate = lr.StartDate,
            Status = lr.Status,
        };
    }

    public static GetLeaveRequestByIdQueryDto MapToGetLeaveRequestByIdQueryDto(this LeaveRequest lr)
    {
        return new GetLeaveRequestByIdQueryDto
        {
            Id = lr.LeaveId,
            CreatedBy = lr.CreatedBy,
            CreatedDate = lr.CreatedDate,
            CreditId = lr.CreditId,
            EmployeeId = lr.EmployeeId,
            EndDate = lr.EndDate,
            LeaveType = lr.LeaveType,
            ModifiedBy = lr.ModifiedBy,
            ModifiedDate = lr.ModifiedDate,
            StartDate = lr.StartDate,
            Status = lr.Status,
        };
    }

    public static GetAllLeaveRequestQueryDto MapToGetAllLeaveRequestQueryDto(this LeaveRequest lr)
    {
        return new GetAllLeaveRequestQueryDto
        {
            Id = lr.LeaveId,
            CreatedBy = lr.CreatedBy,
            CreatedDate = lr.CreatedDate,
            CreditId = lr.CreditId,
            EmployeeId = lr.EmployeeId,
            EndDate = lr.EndDate,
            LeaveType = lr.LeaveType,
            ModifiedBy = lr.ModifiedBy,
            ModifiedDate = lr.ModifiedDate,
            StartDate = lr.StartDate,
            Status = lr.Status,
        };
    }
}
