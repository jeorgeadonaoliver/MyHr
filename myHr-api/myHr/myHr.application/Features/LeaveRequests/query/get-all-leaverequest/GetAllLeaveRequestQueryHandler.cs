
namespace myHr.application.Features.LeaveRequests.query.get_all_leaverequest
{
    public record GetAllLeaveRequestQueryHandler : IRequestHandler<GetAllLeaveRequestQuery, Result<IEnumerable<GetAllLeaveRequestQueryDto>>>
    {
        private readonly ILeaveRequestRepository _repository;
        public GetAllLeaveRequestQueryHandler(ILeaveRequestRepository repository)
        {
            _repository = repository;
        }
        public async Task<Result<IEnumerable<GetAllLeaveRequestQueryDto>>> Handle(GetAllLeaveRequestQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync(cancellationToken);
            if (data.IsFailed)
                return Result.Fail(data.Errors);

            return Result.Ok(data.Value.Select(x => x.MapToGetAllLeaveRequestQueryDto()));
        }
    }
}
