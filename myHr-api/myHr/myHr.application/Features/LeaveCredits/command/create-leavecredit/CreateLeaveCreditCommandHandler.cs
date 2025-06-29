namespace myHr.application.Features.LeaveCredits.command.create_leavecredit;

public class CreateLeaveCreditCommandHandler : IRequestHandler<CreateLeaveCreditCommand, Result<Guid>>
{
    private readonly ILeaveCreditRepository _repository;

    public CreateLeaveCreditCommandHandler(ILeaveCreditRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreateLeaveCreditCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.CreateAsync(request.MapToLeaveCredit(), cancellationToken);
        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
