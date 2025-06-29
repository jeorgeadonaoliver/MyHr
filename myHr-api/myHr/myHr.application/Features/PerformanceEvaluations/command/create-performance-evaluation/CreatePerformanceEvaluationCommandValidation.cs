namespace myHr.application.Features.PerformanceEvaluations.command.create_performance_evaluation
{
    public class CreatePerformanceEvaluationCommandValidation : AbstractValidator<CreatePerformanceEvaluationCommand>
    {
        public readonly IPerformanceEvaluationRepository _respository;
        public CreatePerformanceEvaluationCommandValidation(IPerformanceEvaluationRepository repository)
        {
            _respository = repository;

            RuleFor(x => x.Id)
                .NotNull()
                .WithMessage("Evalautation ID must not be null! ")
                .MustAsync(IsEvaluationExist)
                .WithMessage("Performance Evaluation already Exist! ");
        }

        private async Task<bool> IsEvaluationExist(Guid id, CancellationToken cancellationToken) 
        {
            var result = await _respository.GetAnyAsync(x => x.EvaluationId == id, cancellationToken);
            return !result.Value;
        }
    }
}
