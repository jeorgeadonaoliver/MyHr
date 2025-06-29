public class UpdateJobPositionCommand : BaseDto, IRequest<Result<Guid>>
{
    public string PositionTitle { get; set; } = null!;

    public string? Description { get; set; }

    public Guid? DepartmentId { get; set; }
}
