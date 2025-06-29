namespace myHr.application.Features.PerformanceEvaluations.command.update_performance_evaluation;

public class UpdatePerformanceEvaluationCommand : BaseDto, IRequest<Result<Guid>>
{
    public Guid? EmployeeId { get; set; }

    public DateOnly EvaluationDate { get; set; }

    public string Evaluator { get; set; } = null!;

    public decimal Score { get; set; }

    public string? Comments { get; set; }
}
