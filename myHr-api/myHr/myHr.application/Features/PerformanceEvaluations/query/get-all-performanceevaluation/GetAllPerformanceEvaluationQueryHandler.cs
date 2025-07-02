
namespace myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation
{
    public class GetAllPerformanceEvaluationQueryHandler : IRequestHandler<GetAllPerformanceEvaluationQuery, Result<IEnumerable<GetAllPerformanceEvaluationQueryDto>>>
    {
        private readonly IPerformanceEvaluationRepository _repository;

        public GetAllPerformanceEvaluationQueryHandler(IPerformanceEvaluationRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<GetAllPerformanceEvaluationQueryDto>>> Handle(GetAllPerformanceEvaluationQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);
            if (result.IsFailed)
            {
                return Result.Fail(result.Errors);
            }

            return  Result.Ok(result.Value.Select(x => x.MapToGetAllPerformanceEvaluationQueryDto()));
        }
    }
}
