namespace myHr.api.GraphQL.Query
{
    [ExtendObjectType("Query")]
    public class DepartmentQuery
    {
        [Authorize]
        [GraphQLName("GetAllDepartment")]
        public async Task<PayLoad<IEnumerable<GetAllDepartmentsQueryDto>>> GetAllDepartment([Service] IMediator mediator, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(new GetAllDepartmentsQuery(), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [Authorize]
        [GraphQLName("GetDepartmentById")]
        public async Task<PayLoad<GetDepartmentByIdQueryDto>> GetDepartmentById(Guid id, [Service] IMediator mediator, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(new GetDepartmentByIdQuery(id), cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
