
namespace myHr.application.Features.Departments.query.get_department.by_id
{
    public record GetDepartmentByIdQuery(Guid id) : IRequest<Result<GetDepartmentByIdQueryDto>>;
}
