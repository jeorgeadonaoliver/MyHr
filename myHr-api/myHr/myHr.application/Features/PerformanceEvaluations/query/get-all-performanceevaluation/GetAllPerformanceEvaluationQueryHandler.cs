
namespace myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation
{
    public class GetAllPerformanceEvaluationQueryHandler : IRequestHandler<GetAllPerformanceEvaluationQuery, IEnumerable<GetAllPerformanceEvaluationQueryDto>>
    {
        private readonly IPerformanceEvaluationRepository _repository;

        public GetAllPerformanceEvaluationQueryHandler(IPerformanceEvaluationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetAllPerformanceEvaluationQueryDto>> Handle(GetAllPerformanceEvaluationQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);
            if (result.IsFailed)
            {
                return Enumerable.Empty<GetAllPerformanceEvaluationQueryDto>();
            }

            return result.Value.Select(x => x.MapToGetAllPerformanceEvaluationQueryDto());
        }
    }
}
