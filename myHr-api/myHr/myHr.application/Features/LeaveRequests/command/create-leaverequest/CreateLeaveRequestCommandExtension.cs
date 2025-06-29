namespace myHr.application.Features.LeaveRequests.command.create_leaverequest;

public static class CreateLeaveRequestCommandExtension
{
    public static LeaveRequest MapToLeaveRequest(this CreateLeaveRequestCommand cmd) 
    {
        return new LeaveRequest { 
        
            EmployeeId = cmd.EmployeeId,
            LeaveId = cmd.Id,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            CreditId = cmd.CreditId,
            EndDate = cmd.EndDate,
            StartDate = cmd.StartDate,
            Status = cmd.Status,
            LeaveType = cmd.LeaveType
        };
    }
}
