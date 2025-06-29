using myHr.application.Features.Employees.Command.create_employee;
using myHr.application.Features.Employees.Command.update_employee;

namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class EmployeeMutation
    {
        [GraphQLName("CreateEmployee")]
        public async Task<PayLoad<Guid>> CreateEmployee([Service] IMediator mediator, CreateEmployeeCommand cmd, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdateEmployee")]
        public async Task<PayLoad<Guid>> UpdateEmployee([Service] IMediator mediator, [GraphQLName("command")] UpdateEmployeeCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
