namespace myHr.application.Features.PerformanceEvaluations.query.get_all_performanceevaluation;

public class GetAllPerformanceEvaluationQueryDto : BaseDto
{
    public Guid? EmployeeId { get; set; }

    public DateOnly EvaluationDate { get; set; }

    public string Evaluator { get; set; } = null!;

    public decimal Score { get; set; }

    public string? Comments { get; set; }

}
