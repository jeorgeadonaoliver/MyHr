namespace myHr.application.Features.Departments.command.create_department;

public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, Result<Guid>>
{
    private readonly IDepartmentRepository _repository;
    public CreateDepartmentCommandHandler(IDepartmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await ValidationHandler.ValidateAsync(new CreateDepartmentCommandValidation(_repository), request, cancellationToken);

        if (validationResult.IsFailed) 
        {
            return Result.Fail<Guid>(validationResult.Errors);
        }

        request.CreatedDate = DateTime.UtcNow;
        request.CreatedBy = "Admin";
        var departments = request.MapToDepartment();

        var result = await _repository.CreateAsync(departments, cancellationToken);
        if (result.IsFailed) 
        {
            return Result.Fail<Guid>(result.Errors);
        }

        return Result.Ok(request.Id);
        
    }
}
