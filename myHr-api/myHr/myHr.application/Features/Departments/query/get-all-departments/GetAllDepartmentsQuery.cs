namespace myHr.application.Features.Departments.query.get_all_departments;

public record GetAllDepartmentsQuery 
    : IRequest<Result<IEnumerable<GetAllDepartmentsQueryDto>>> { }
