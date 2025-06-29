namespace myHr.application.Features.JobPositions.command.update_jobposition;

public class UpdateJobPositionCommandValidation : AbstractValidator<UpdateJobPositionCommand>
{
    private readonly IJobPositionRepository _repository;
    public UpdateJobPositionCommandValidation(IJobPositionRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Position ID must not be null!")
            .MustAsync(IsJobPositionExist)
            .WithMessage("Job position Does not Exist!");

        RuleFor(x => x.PositionTitle)
            .NotNull()
            .WithMessage("Position Title must not be null!");
    }

    private async Task<bool> IsJobPositionExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.PositionId == id, cancellationToken);
        return result.Value;
    }
}
