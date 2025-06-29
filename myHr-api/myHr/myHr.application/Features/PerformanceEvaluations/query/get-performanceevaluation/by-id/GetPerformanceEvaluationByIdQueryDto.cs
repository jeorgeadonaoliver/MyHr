namespace myHr.application.Features.PerformanceEvaluations.query.get_performanceevaluation.by_id;
public class GetPerformanceEvaluationByIdQueryDto : BaseDto
{
    public Guid? EmployeeId { get; set; }

    public DateOnly EvaluationDate { get; set; }

    public string Evaluator { get; set; } = null!;

    public decimal Score { get; set; }

    public string? Comments { get; set; }
}
