namespace myHr.application.Features.LeaveRequests.query.get_leaverequest.by_leaverequest_id;

public record GetLeaveRequestByIdQuery(Guid leaverequestid) : IRequest<Result<GetLeaveRequestByIdQueryDto>>;
