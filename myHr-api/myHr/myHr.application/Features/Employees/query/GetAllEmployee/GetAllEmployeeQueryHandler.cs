namespace myHr.application.Features.Employees.query.GetAllEmployee;

public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, Result<IEnumerable<GetAllEmployeeQueryDto>>>
{
    private readonly IEmployeeRepository _repository;

    public GetAllEmployeeQueryHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<IEnumerable<GetAllEmployeeQueryDto>>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync(cancellationToken);
        if (result.IsFailed)
        {
            return Result.Ok(Enumerable.Empty<GetAllEmployeeQueryDto>());
        }

        return Result.Ok(result.Value.Select(x => x.MapToGetAllEmployeeQueryDto()));
    }
}
