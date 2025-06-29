namespace myHr.application.Features.Employees.query.get_employee.by_id;

public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Result<GetEmployeeByIdQueryDto>>
{
    private readonly IEmployeeRepository _repository;
    public GetEmployeeByIdQueryHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<GetEmployeeByIdQueryDto>> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAsync(x => x.EmployeeId == request.id, cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors);
        }

        return Result.Ok(result.Value.MapToGetEmployeeByIdQuery());
    }
}
