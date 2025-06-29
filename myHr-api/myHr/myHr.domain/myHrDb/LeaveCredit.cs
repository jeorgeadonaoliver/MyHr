namespace myHr.domain.myHrDb;

public partial class LeaveCredit
{
    public Guid CreditId { get; set; }

    public Guid? EmployeeId { get; set; }

    public string LeaveType { get; set; } = null!;

    public int TotalCredits { get; set; }

    public int? UsedCredits { get; set; }

    public int? RemainingCredits { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
}
