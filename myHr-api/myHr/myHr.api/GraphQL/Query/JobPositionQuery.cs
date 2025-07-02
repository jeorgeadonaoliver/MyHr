namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class JobPositionQuery
    {
        [Authorize]
        [GraphQLName("GetAllJobPosition")]
        public async Task<PayLoad<IEnumerable<GetAllJobPositionsQueryDto>>> GetAllJobPosition([Service] IMediator mediator, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetAllJobPositionsQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [Authorize]
        [GraphQLName("GetAllJobPositionById")]
        public async Task<PayLoad<GetJobPositionByIdQueryDto>> GetJobPositionById([Service] IMediator mediator, Guid id, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetJobPositionByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
