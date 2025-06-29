

namespace myHr.application.Features.Departments.query.get_department.by_id;

public class GetDepartmentByIdQueryDto : BaseDto
{
    public string DepartmentName { get; set; } = null!;

    public string? Location { get; set; }
}
