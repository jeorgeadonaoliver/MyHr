

namespace myHr.application.Features.LeaveRequests.command.update_leaverequest;

public class UpdateLeaveRequestCommandValidation : AbstractValidator<UpdateLeaveRequestCommand>
{
    private readonly ILeaveRequestRepository _repository;
    public UpdateLeaveRequestCommandValidation(ILeaveRequestRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Leave Request ID must not be null! ")
            .MustAsync(IsLeaveRequestExist)
            .WithMessage("Leave Request does not exist! ");

        RuleFor(x => x.LeaveType)
            .NotNull()
            .WithMessage("Leave Type must not be null! ")
            .MustAsync(IsLeaveRequestExist)
            .WithMessage("Leave Type Already Exist! ")
            ;
    }

    private async Task<bool> IsLeaveRequestExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.LeaveId == id, cancellationToken);
        return result.Value;
    }

    private async Task<bool> IsLeaveRequestExist(string leavetype, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAnyAsync(x => x.LeaveType == leavetype, cancellationToken);
        return result.Value;
    }
}
