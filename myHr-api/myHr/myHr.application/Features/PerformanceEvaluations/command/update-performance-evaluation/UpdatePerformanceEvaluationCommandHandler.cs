
namespace myHr.application.Features.PerformanceEvaluations.command.update_performance_evaluation;

public class UpdatePerformanceEvaluationCommandHandler : IRequestHandler<UpdatePerformanceEvaluationCommand, Result<Guid>>
{
    private readonly IPerformanceEvaluationRepository _repository;
    public UpdatePerformanceEvaluationCommandHandler(IPerformanceEvaluationRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdatePerformanceEvaluationCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await ValidationHandler.ValidateAsync(new UpdatePerformanceEvaluationCommandValidation(_repository), request, cancellationToken);

        if (validationResult.IsFailed)
        {
            return Result.Fail(validationResult.Errors);
        }

        var data = request.MapToPerformanceEvaluation();
        var result = await _repository.UpdateAsync(data, cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors); 
        }

        return Result.Ok(request.Id);
    }
}
