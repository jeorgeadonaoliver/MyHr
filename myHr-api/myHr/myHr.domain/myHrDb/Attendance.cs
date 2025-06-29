namespace myHr.domain.myHrDb;

public partial class Attendance
{
    public Guid AttendanceId { get; set; }

    public Guid? EmployeeId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly? CheckInTime { get; set; }

    public TimeOnly? CheckOutTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Employee? Employee { get; set; }
}
