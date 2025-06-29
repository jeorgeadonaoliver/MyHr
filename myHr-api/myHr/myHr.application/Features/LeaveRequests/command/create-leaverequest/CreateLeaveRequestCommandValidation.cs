namespace myHr.application.Features.LeaveRequests.command.create_leaverequest;

public class CreateLeaveRequestCommandValidation : AbstractValidator<CreateLeaveRequestCommand>
{
    private readonly ILeaveRequestRepository _repository;
    public CreateLeaveRequestCommandValidation(ILeaveRequestRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Leave Request ID must not be null! ")
            .MustAsync(IsLeaveRequestExist)
            .WithMessage("Leave Request already Exist!");

        RuleFor(x => x.LeaveType)
            .NotNull()
            .WithMessage("Leave Type must not be null! ")
            .MustAsync(IsLeaveRequestExist)
            .WithMessage("Leave Request Already Exist! ");
    }

    private async Task<bool> IsLeaveRequestExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.LeaveId == id, cancellationToken);
        return !result.Value;
    }

    private async Task<bool> IsLeaveRequestExist(string leaveType, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAnyAsync(x => x.LeaveType == leaveType, cancellationToken);
        return !result.Value;
    }
}
