
namespace myHr.application.Features.Departments.query.get_all_departments;

public class GetAllDepartmentsQueryHandler 
    : IRequestHandler<GetAllDepartmentsQuery, Result<IEnumerable<GetAllDepartmentsQueryDto>>>
{
    private readonly IDepartmentRepository _repository;
    public GetAllDepartmentsQueryHandler(IDepartmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<IEnumerable<GetAllDepartmentsQueryDto>>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync(cancellationToken);
        if (result.IsFailed)
        {
            return Result.Fail(result.Errors.Select(x => x.Message));
        }

        return result.Value.Select(c => c.MapToGetAllDepartmentsQueryDto()).ToList();
    }
}
