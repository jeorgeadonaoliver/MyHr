
namespace myHr.domain.myHrDb;

public partial class PerformanceEvaluation
{
    public Guid EvaluationId { get; set; }

    public Guid? EmployeeId { get; set; }

    public DateOnly EvaluationDate { get; set; }

    public string Evaluator { get; set; } = null!;

    public decimal Score { get; set; }

    public string? Comments { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Employee? Employee { get; set; }
}
