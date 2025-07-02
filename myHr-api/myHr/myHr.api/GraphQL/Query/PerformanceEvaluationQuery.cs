using myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation;
using myHr.application.Features.PerformanceEvaluations.query.get_performanceevaluation.by_id;

namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class PerformanceEvaluationQuery
    {
        [Authorize]
        [GraphQLName("GetAllPerformanceEvaluation")]
        public async Task<PayLoad<IEnumerable<GetAllPerformanceEvaluationQueryDto>>> GetAllPerformanceEvaluation(
            [Service] IMediator mediator, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetAllPerformanceEvaluationQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [Authorize]
        [GraphQLName("GetPerformanceEvaluationById")]
        public async Task<PayLoad<GetPerformanceEvaluationByIdQueryDto>> GetPerformanceEvaluation(
            [Service] IMediator mediator, Guid id, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(new GetPerformanceEvaluationByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
