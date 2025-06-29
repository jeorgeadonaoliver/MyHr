namespace myHr.application.Features.Departments.command.update_department
{
    public class UpdateDepartmentCommand : BaseDto, IRequest<Result<Guid>>
    {
        public string DepartmentName { get; set; } = null!;

        public string? Location { get; set; }
    }
}
