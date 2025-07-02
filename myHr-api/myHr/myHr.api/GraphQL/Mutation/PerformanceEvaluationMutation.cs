using myHr.application.Features.PerformanceEvaluations.command.create_performance_evaluation;
using myHr.application.Features.PerformanceEvaluations.command.update_performance_evaluation;

namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class PerformanceEvaluationMutation
    {
        [GraphQLName("CreatePerformanceEvaluation")]
        public async Task<PayLoad<Guid>> CreatePerformanceEvaluation([Service] IMediator mediator, CreatePerformanceEvaluationCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdatePerformanceEvaluation")]
        public async Task<PayLoad<Guid>> UpdatePerformanceEvaluation([Service] IMediator mediator, UpdatePerformanceEvaluationCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
