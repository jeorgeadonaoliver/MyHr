using myHr.application.Features.Employees.Command.create_employee;

namespace myHr.application.Features.Employees.command.create_employee;

public class CreateEmployeeCommandValidation : AbstractValidator<CreateEmployeeCommand>
{
    private readonly IEmployeeRepository _repository;

    public CreateEmployeeCommandValidation(IEmployeeRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Employee Id must not be null!")
            .MustAsync(IsEmployeeExist)
            .WithMessage("Employee Already Exist!");
    }

    private async Task<bool> IsEmployeeExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.EmployeeId == id, cancellationToken);
        return !result.Value;
    }
}
