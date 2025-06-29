namespace myHr.application.Features.Employees.query.GetAllEmployee;

public record GetAllEmployeeQuery : IRequest<Result<IEnumerable<GetAllEmployeeQueryDto>>>;
