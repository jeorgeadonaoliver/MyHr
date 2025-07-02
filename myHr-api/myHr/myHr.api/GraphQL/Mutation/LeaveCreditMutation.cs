using myHr.application.Features.LeaveCredits.command.update_leavecredit;

namespace myHr.api.GraphQL.Mutation
{
    [ExtendObjectType("Mutation")]
    public class LeaveCreditMutation
    {
        [GraphQLName("CreateLeaveCredit")]
        public async Task<PayLoad<Guid>> CreateLeaveCredit([Service] IMediator mediator, CreateLeaveCreditCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }

        [GraphQLName("UpdateLeaveCredit")]
        public async Task<PayLoad<Guid>> UpdateLeaveCredit([Service] IMediator mediator, UpdateLeaveCreditCommand cmd, CancellationToken cancellationToken) 
        {
            var response = await mediator.Send(cmd, cancellationToken);
            return PayLoadFactory.ProduceResult(response);
        }
    }
}
