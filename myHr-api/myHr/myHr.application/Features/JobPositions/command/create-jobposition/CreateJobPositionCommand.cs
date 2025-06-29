
namespace myHr.application.Features.JobPositions.command.create_jobposition
{
    public class CreateJobPositionCommand :  BaseDto, IRequest<Result<Guid>>
    {
        public string PositionTitle { get; set; } = null!;

        public string? Description { get; set; }

        public Guid? DepartmentId { get; set; }

    }
}
