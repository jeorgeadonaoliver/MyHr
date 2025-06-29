using myHr.application.Features.JobPositions.query.get_all_jobpositions;
using myHr.application.Features.JobPositions.query.get_jobpositions.by_id;

namespace myHr.application.Extension;

public static class JobPositionExtension
{
    public static GetAllJobPositionsQueryDto MapToGetAllJobPositionsQueryDto(this JobPosition jp) 
    {
        return new GetAllJobPositionsQueryDto 
        {
            CreatedBy = jp.CreatedBy,
            Id = jp.PositionId,
            CreatedDate = jp.CreatedDate,
            DepartmentId = jp.DepartmentId,
            Description = jp.Description,
            ModifiedBy = jp.ModifiedBy,
            ModifiedDate = jp.ModifiedDate,
            PositionTitle = jp.PositionTitle
        };
    }

    public static GetJobPositionByIdQueryDto MapToGetJobPositionByIdQueryDto(this JobPosition jp)
    {
        return new GetJobPositionByIdQueryDto
        {
            CreatedBy = jp.CreatedBy,
            Id = jp.PositionId,
            CreatedDate = jp.CreatedDate,
            DepartmentId = jp.DepartmentId,
            Description = jp.Description,
            ModifiedBy = jp.ModifiedBy,
            ModifiedDate = jp.ModifiedDate,
            PositionTitle = jp.PositionTitle
        };
    }
}
