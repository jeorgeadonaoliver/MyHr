namespace myHr.application.Features.Departments.command.update_department;

public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, Result<Guid>>
{
    private readonly IDepartmentRepository _repository;
    public UpdateDepartmentCommandHandler(IDepartmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await ValidationHandler.ValidateAsync(new UpdateDepartmentCommandValidation(_repository),request, cancellationToken);
        if (validationResult.IsFailed)
            return Result.Fail(validationResult.Errors);

        var result = await _repository.UpdateAsync(request.MapToDepartment(), cancellationToken);
        if (result.IsFailed)  
            return Result.Fail(result.Errors);

        return Result.Ok(request.Id);
    }
}
