namespace myHr.application.Features.Employees.command.update_employee;

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Result<Guid>>
{
    private readonly IEmployeeRepository _repository;
    public UpdateEmployeeCommandHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await ValidationHandler.ValidateAsync(new UpdateEmployeeCommandValidation(_repository), request, cancellationToken);

        if (validationResult.IsFailed)
        {
            return Result.Fail(validationResult.Errors.Select(x => x.Message));
        }

        request.ModifiedBy = "Admin";
        request.ModifiedDate = DateTime.UtcNow;
        var result = await _repository.UpdateAsync(request.MapToEmployee(), cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors.Select(x => x.Message));
        }

        return Result.Ok(request.Id);
    }
}