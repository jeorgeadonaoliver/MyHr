namespace myHr.application.Features.LeaveCredits.command.update_leavecredit;

public class UpdateLeaveCreditCommandValidation : AbstractValidator<UpdateLeaveCreditCommand>
{
    private readonly ILeaveCreditRepository _repository;

    public UpdateLeaveCreditCommandValidation(ILeaveCreditRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Leave Credit ID must not be null!")
            .MustAsync(IsLeaveCreditExist)
            .WithMessage("Leave Credit does not exist");

        RuleFor(x => x.RemainingCredits)
            .NotNull()
            .WithMessage("Leave Credit must not be null!")
            .MustAsync(IsGreaterThanZero)
            .WithMessage("Leave credit must be greater than zero!");
    }

    private Task<bool> IsGreaterThanZero(int? credit, CancellationToken cancellationToken) 
    {
        return Task.FromResult(credit > 0 ? true : false);
    }

    private async Task<bool> IsLeaveCreditExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.CreditId == id, cancellationToken);
        return result.Value;
    }
}
