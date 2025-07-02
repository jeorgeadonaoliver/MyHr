namespace myHr.application.Features.LeaveRequests.query.get_leaverequest.by_leaverequest_id;

public class GetLeaveRequestByIdQueryHandler : IRequestHandler<GetLeaveRequestByIdQuery, Result<GetLeaveRequestByIdQueryDto>>
{
    private readonly ILeaveRequestRepository _repository;
    public GetLeaveRequestByIdQueryHandler(ILeaveRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<GetLeaveRequestByIdQueryDto>> Handle(GetLeaveRequestByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAsync(x => x.LeaveId == request.leaverequestid, cancellationToken);
        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.MapToGetLeaveRequestByIdQueryDto()); 
    }
}
