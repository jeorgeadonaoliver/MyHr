namespace myHr.application.Features.JobPositions.query.get_jobpositions.by_id
{
    public class GetJobPositionByIdQueryDto : BaseDto
    {
        public string PositionTitle { get; set; } = null!;

        public string? Description { get; set; }

        public Guid? DepartmentId { get; set; }
    }
}
