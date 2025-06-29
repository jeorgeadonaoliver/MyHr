
namespace myHr.application.Features.Departments.query.get_department.by_id
{
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, Result<GetDepartmentByIdQueryDto>>
    {
        private readonly IDepartmentRepository _repository;
        public GetDepartmentByIdQueryHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<GetDepartmentByIdQueryDto>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAsync(x => x.DepartmentId == request.id, cancellationToken);
            if (result.IsFailed) 
            {
                Result.Fail(result.Errors);
            }

            return Result.Ok(result.Value.MapToGetDepartmentByIdQueryDto());
        }
    }
}
