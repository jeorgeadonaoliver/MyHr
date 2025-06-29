namespace myHr.application.Features.PerformanceEvaluations.command.update_performance_evaluation;

public class UpdatePerformanceEvaluationCommandValidation : AbstractValidator<UpdatePerformanceEvaluationCommand>
{
    public readonly IPerformanceEvaluationRepository _repository;

    public UpdatePerformanceEvaluationCommandValidation(IPerformanceEvaluationRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Evaluation ID must not be null! ")
            .MustAsync(IsPerformanceEvaluiation)
            .WithMessage("Evaluation ID does not exist! ");
    }

    private async Task<bool> IsPerformanceEvaluiation(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.EvaluationId == id, cancellationToken);
        return result.Value;
    }
}
