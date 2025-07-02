namespace myHr.application.Features.LeaveRequests.query.get_all_leaverequest
{
    public record GetAllLeaveRequestQuery : IRequest<Result<IEnumerable<GetAllLeaveRequestQueryDto>>>;
    
}
