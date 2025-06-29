using myHr.application.Features.Employees.Command.create_employee;

namespace myHr.application.Features.Employees.command.create_employee;

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Result<Guid>>
{
    private readonly IEmployeeRepository _repository;
    public CreateEmployeeCommandHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await ValidationHandler.ValidateAsync(new CreateEmployeeCommandValidation(_repository), request, cancellationToken);
        if (validationResult.IsFailed) 
        {
            return Result.Fail(validationResult.Errors.Select(x => x.Message));
        }

        request.CreatedDate = DateTime.UtcNow;
        request.CreatedBy = "Admin";
        var result = await _repository.CreateAsync(request.MapToEmployee(), cancellationToken);

        if (result.IsFailed)
        {
            return Result.Fail(result.Errors.Select(x => x.Message));
        }

        return Result.Ok(request.Id);
    }
}
