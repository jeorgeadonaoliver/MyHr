
namespace myHr.application.Features.LeaveCredits.command.update_leavecredit;

public class UpdateLeaveCreditCommandHandler : IRequestHandler<UpdateLeaveCreditCommand, Result<Guid>>
{
    private readonly ILeaveCreditRepository _repository;
    public UpdateLeaveCreditCommandHandler(ILeaveCreditRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdateLeaveCreditCommand request, CancellationToken cancellationToken)
    {
        request.ModifiedBy = "Admin";
        request.ModifiedDate = DateTime.UtcNow;
        var result = await _repository.UpdateAsync(request.MapToLeaveCredit(), cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
