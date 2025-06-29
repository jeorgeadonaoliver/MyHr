
namespace myHr.application.Features.PerformanceEvaluations.command.create_performance_evaluation;

public class CreatePerformanceEvaluationCommandHandler : IRequestHandler<CreatePerformanceEvaluationCommand, Result<Guid>>
{
    private readonly IPerformanceEvaluationRepository _repository;
    public CreatePerformanceEvaluationCommandHandler(IPerformanceEvaluationRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreatePerformanceEvaluationCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.CreateAsync(request.MapToPerformanceEvaluation(), cancellationToken);
        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(request.Id);
    }
}
