namespace myHr.application.Features.JobPositions.query.get_all_jobpositions
{
    public class GetAllJobPositionsQueryDto : BaseDto
    {
        public string PositionTitle { get; set; } = null!;

        public string? Description { get; set; }

        public Guid? DepartmentId { get; set; }

    }
}
