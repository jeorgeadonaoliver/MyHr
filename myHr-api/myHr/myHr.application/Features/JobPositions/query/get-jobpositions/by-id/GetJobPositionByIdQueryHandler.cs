namespace myHr.application.Features.JobPositions.query.get_jobpositions.by_id;

public class GetJobPositionByIdQueryHandler : IRequestHandler<GetJobPositionByIdQuery, Result<GetJobPositionByIdQueryDto>>
{
    private readonly IJobPositionRepository _repository;
    public GetJobPositionByIdQueryHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<GetJobPositionByIdQueryDto>> Handle(GetJobPositionByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAsync(x => x.PositionId == request.id, cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.MapToGetJobPositionByIdQueryDto());
    }
}
