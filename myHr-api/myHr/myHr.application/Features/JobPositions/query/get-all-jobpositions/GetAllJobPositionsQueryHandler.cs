namespace myHr.application.Features.JobPositions.query.get_all_jobpositions;

public class GetAllJobPositionsQueryHandler : IRequestHandler<GetAllJobPositionsQuery, Result<IEnumerable<GetAllJobPositionsQueryDto>>>
{
    private readonly IJobPositionRepository _repository;

    public GetAllJobPositionsQueryHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<IEnumerable<GetAllJobPositionsQueryDto>>> Handle(GetAllJobPositionsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync(cancellationToken);
        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.Select(x => x.MapToGetAllJobPositionsQueryDto()));
    }
}
