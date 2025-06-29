
namespace myHr.application.Features.LeaveRequests.command.update_leaverequest;

public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Result<Guid>>
{
    private readonly ILeaveRequestRepository _repository;
    public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        request.ModifiedBy = "Admin";
        request.ModifiedDate = DateTime.UtcNow;
        var result = await _repository.UpdateAsync(request.MapToLeaveRequest(), cancellationToken);

        if (result.IsFailed) 
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
