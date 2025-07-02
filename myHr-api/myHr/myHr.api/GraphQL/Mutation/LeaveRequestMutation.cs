using myHr.application.Features.LeaveRequests.command.create_leaverequest;
using myHr.application.Features.LeaveRequests.command.update_leaverequest;

namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class LeaveRequestMutation
    {
        [GraphQLName("CreateLeaveRequest")]
        public async Task<PayLoad<Guid>> CreateLeaveRequest([Service] IMediator mediator, CreateLeaveRequestCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdateLeaveRequest")]
        public async Task<PayLoad<Guid>> UpdateLeaveRequest([Service] IMediator mediator, UpdateLeaveRequestCommand cmd, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
