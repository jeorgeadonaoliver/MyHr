
namespace myHr.application.Features.Departments.query.get_all_departments;

public class GetAllDepartmentsQueryDto : BaseDto
{
    public string DepartmentName { get; set; } = null!;

    public string? Location { get; set; }
}
