namespace myHr.domain.myHrDb;

public partial class LeaveRequest
{
    public Guid LeaveId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreditId { get; set; }

    public string LeaveType { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual LeaveCredit? Credit { get; set; }

    public virtual Employee? Employee { get; set; }
}
