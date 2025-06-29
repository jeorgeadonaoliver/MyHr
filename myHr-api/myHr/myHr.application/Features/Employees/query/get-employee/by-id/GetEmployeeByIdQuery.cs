namespace myHr.application.Features.Employees.query.get_employee.by_id;

public record GetEmployeeByIdQuery(Guid id) : IRequest<Result<GetEmployeeByIdQueryDto>>;
