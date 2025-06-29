namespace myHr.application.Features.LeaveCredits.command.create_leavecredit;

public class CreateLeaveCreditCommandValidation : AbstractValidator<CreateLeaveCreditCommand>
{
    private readonly ILeaveCreditRepository _repository;

    public CreateLeaveCreditCommandValidation(ILeaveCreditRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.TotalCredits)
            .NotNull()
            .WithMessage("Leave Credit must not be null!");
    }
}
