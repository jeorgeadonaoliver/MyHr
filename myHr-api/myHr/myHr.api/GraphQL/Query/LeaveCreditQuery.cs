namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class LeaveCreditQuery
    {
        [Authorize]
        [GraphQLName("GetAllLeaveCredits")]
        public async Task<PayLoad<IEnumerable<GetAllLeaveCreditQueryDto>>> GetAllLeaveCredit([Service] IMediator mediator, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetAllLeaveCreditQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [Authorize]
        [GraphQLName("GetLeaveCreditById")]
        public async Task<PayLoad<GetLeaveRequestByIdQueryDto>> GetLeaveCreditById([Service] IMediator mediator, Guid id, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetLeaveRequestByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
