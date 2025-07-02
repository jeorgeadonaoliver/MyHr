namespace myHr.application.Features.LeaveRequests.query.get_leaverequest.by_employee_id;

public record GetLeaveRequestByEmployeeIdQuery(Guid employeeid) : IRequest<Result<IEnumerable<GetLeaveRequestByEmployeeIdQueryDto>>>;
