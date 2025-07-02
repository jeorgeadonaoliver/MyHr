namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class LeaveRequestQuery
    {
        [Authorize]
        [GraphQLName("GetAllLeaveRequest")]
        public async Task<PayLoad<IEnumerable<GetAllLeaveRequestQueryDto>>> GetAllLeaveRequest([Service] IMediator mediator, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetAllLeaveRequestQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("GetLeaveRequestById")]
        public async Task<PayLoad<GetLeaveRequestByIdQueryDto>> GetLeaveRequestById([Service] IMediator mediator, Guid id, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetLeaveRequestByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [Authorize]
        [GraphQLName("GetLeaveRequestByEmployeeId")]
        public async Task<PayLoad<IEnumerable<GetLeaveRequestByEmployeeIdQueryDto>>> GetLeaveRequestByEmployeeId(IMediator mediator, Guid empid, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(new GetLeaveRequestByEmployeeIdQuery(empid), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
