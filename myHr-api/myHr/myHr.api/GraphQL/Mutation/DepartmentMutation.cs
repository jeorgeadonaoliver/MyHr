using myHr.application.Features.Departments.command.create_department;
using myHr.application.Features.Departments.command.update_department;

namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class DepartmentMutation
    {
        [GraphQLName("CreateDepartment")]
        public async Task<PayLoad<Guid>> CreateDepartmentAsync([Service] IMediator mediator, [GraphQLName("command")] CreateDepartmentCommand cmd, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdateDepartment")]
        public async Task<PayLoad<Guid>> UpdateDepartment([Service] IMediator mediator, [GraphQLName("command")] UpdateDepartmentCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
