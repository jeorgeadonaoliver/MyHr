namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class JobPositionMutation
    {
        [GraphQLName("CreateJobPosition")]
        public async Task<PayLoad<Guid>> CeateJobPosition([Service] IMediator mediator, [GraphQLName("command")] CreateJobPositionCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdateJobPosition")]
        public async Task<PayLoad<Guid>> UpdateJobPosition([Service] IMediator mediator, [GraphQLName("command")] UpdateJobPositionCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
