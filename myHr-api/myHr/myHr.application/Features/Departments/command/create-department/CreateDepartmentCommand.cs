namespace myHr.application.Features.Departments.command.create_department
{
    public class CreateDepartmentCommand : IRequest<Result<Guid>>
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string CreatedBy { get; set; } = "system";

        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;

        public string DepartmentName { get; set; } = null!;

        public string? Location { get; set; }

    }
}
