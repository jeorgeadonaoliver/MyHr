namespace myHr.application.Features.PerformanceEvaluations.command.create_performance_evaluation;

public class CreatePerformanceEvaluationCommand : BaseDto, IRequest<Result<Guid>>
{
    public Guid? EmployeeId { get; set; }

    public DateOnly EvaluationDate { get; set; }

    public string Evaluator { get; set; } = null!;

    public decimal Score { get; set; }

    public string? Comments { get; set; }

}
