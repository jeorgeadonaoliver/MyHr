
using myHr.application.Features.Departments.query.get_department.by_id;

namespace myHr.application.Extension;

public static class DepartmentExtension
{
    public static GetAllDepartmentsQueryDto MapToGetAllDepartmentsQueryDto(this Department dep) 
    {
        return new GetAllDepartmentsQueryDto() 
        { 
            Id = dep.DepartmentId,
            CreatedBy = dep.CreatedBy,
            CreatedDate = dep.CreatedDate,
            DepartmentName = dep.DepartmentName,
            Location = dep.Location,
            ModifiedBy = dep.ModifiedBy,
            ModifiedDate = dep.ModifiedDate,
        };
    }

    public static GetDepartmentByIdQueryDto MapToGetDepartmentByIdQueryDto(this Department dep)
    {
        return new GetDepartmentByIdQueryDto()
        {
            Id = dep.DepartmentId,
            CreatedBy = dep.CreatedBy,
            CreatedDate = dep.CreatedDate,
            DepartmentName = dep.DepartmentName,
            Location = dep.Location,
            ModifiedBy = dep.ModifiedBy,
            ModifiedDate = dep.ModifiedDate,
        };
    }

}
