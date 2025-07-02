namespace myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation;

public record GetAllPerformanceEvaluationQuery : IRequest<Result<IEnumerable<GetAllPerformanceEvaluationQueryDto>>>;
