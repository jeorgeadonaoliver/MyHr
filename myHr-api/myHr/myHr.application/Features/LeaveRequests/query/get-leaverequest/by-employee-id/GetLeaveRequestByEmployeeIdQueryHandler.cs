namespace myHr.application.Features.LeaveRequests.query.get_leaverequest.by_employee_id;

public class GetLeaveRequestByEmployeeIdQueryHandler : IRequestHandler<GetLeaveRequestByEmployeeIdQuery, IEnumerable<GetLeaveRequestByEmployeeIdQueryDto>>
{
    private readonly ILeaveRequestRepository _repository;

    public GetLeaveRequestByEmployeeIdQueryHandler(ILeaveRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GetLeaveRequestByEmployeeIdQueryDto>> Handle(GetLeaveRequestByEmployeeIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync(x => x.EmployeeId == request.employeeid, cancellationToken);

        if (result.IsFailed)
        {
            return Enumerable.Empty<GetLeaveRequestByEmployeeIdQueryDto>();
        }

        return result.Value.Select(x => x.MapToGetLeaveRequestByEmployeeIdQueryDto()).ToList();
    }
}
