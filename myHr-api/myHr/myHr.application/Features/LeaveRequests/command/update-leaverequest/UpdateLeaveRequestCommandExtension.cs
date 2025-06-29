namespace myHr.application.Features.LeaveRequests.command.update_leaverequest;
public static class UpdateLeaveRequestCommandExtension
{
    public static LeaveRequest MapToLeaveRequest(this UpdateLeaveRequestCommand cmd)
    {
        return new LeaveRequest
        {
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
