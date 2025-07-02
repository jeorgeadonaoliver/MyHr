namespace myHr.application.Features.JobPositions.query.get_all_jobpositions;

public record GetAllJobPositionsQuery : IRequest<Result<IEnumerable<GetAllJobPositionsQueryDto>>>;
