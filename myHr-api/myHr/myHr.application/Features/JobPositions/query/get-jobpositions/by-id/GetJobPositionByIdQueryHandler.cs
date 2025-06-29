
namespace myHr.application.Features.JobPositions.query.get_jobpositions.by_id;

internal class GetJobPositionByIdQueryHandler : IRequestHandler<GetJobPositionByIdQuery, GetJobPositionByIdQueryDto>
{
    private readonly IJobPositionRepository _repository;
    public GetJobPositionByIdQueryHandler(IJobPositionRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetJobPositionByIdQueryDto> Handle(GetJobPositionByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAsync(x => x.PositionId == request.id, cancellationToken);

        if (result.IsFailed)
        {
            return new GetJobPositionByIdQueryDto();
        }

        return result.Value.MapToGetJobPositionByIdQueryDto();
    }
}
