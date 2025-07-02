namespace myHr.application.Features.JobPositions.query.get_jobpositions.by_id;

public record GetJobPositionByIdQuery(Guid id) : IRequest<Result<GetJobPositionByIdQueryDto>>;
