
namespace myHr.application.Features.PerformanceEvaluations.query.get_performanceevaluation.by_id;

public class GetPerformanceEvaluationByIdQueryHandler : IRequestHandler<GetPerformanceEvaluationByIdQuery, Result<GetPerformanceEvaluationByIdQueryDto>>
{
    private readonly IPerformanceEvaluationRepository _repositoty;

    public GetPerformanceEvaluationByIdQueryHandler(IPerformanceEvaluationRepository repository)
    {
        _repositoty = repository;
    }

    public async Task<Result<GetPerformanceEvaluationByIdQueryDto>> Handle(GetPerformanceEvaluationByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repositoty.GetAsync(x => x.EvaluationId == request.evaluationId, cancellationToken);
        if (result.IsFailed) 
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.MapToGetPerformanceEvaluationByIdQueryDto());
    }
}
