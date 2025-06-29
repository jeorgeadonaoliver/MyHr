namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class EmployeeQuery
    {
        [Authorize]
        [GraphQLName("getEmployee")]
        public async Task<PayLoad<IEnumerable<GetAllEmployeeQueryDto>>> GetAllEmployee([Service] IMediator mediator, CancellationToken cancellationToken) 
        {
            var data = await mediator.Send(new GetAllEmployeeQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(data);
        }

        [Authorize]
        [GraphQLName("GetEmployeeById")]
        public async Task<PayLoad<GetEmployeeByIdQueryDto>> GetEmployeeById(Guid id, [Service] IMediator mediator, CancellationToken cancellationToken)
        {
            var data = await mediator.Send(new GetEmployeeByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(data);
        }
    }
}
