namespace myHr.application.Features.PerformanceEvaluations.query.get_performanceevaluation.by_id;

public record GetPerformanceEvaluationByIdQuery(Guid evaluationId) : IRequest<Result< GetPerformanceEvaluationByIdQueryDto>>;
