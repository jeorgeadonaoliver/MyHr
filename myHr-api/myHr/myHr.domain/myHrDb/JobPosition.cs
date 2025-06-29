namespace myHr.domain.myHrDb;

public partial class JobPosition
{
    public Guid PositionId { get; set; }

    public string PositionTitle { get; set; } = null!;

    public string? Description { get; set; }

    public Guid? DepartmentId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
