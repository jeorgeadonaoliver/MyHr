using myHr.application.Features.Employees.Command.update_employee;

namespace myHr.application.Features.Employees.command.update_employee;

public class UpdateEmployeeCommandValidation : AbstractValidator<UpdateEmployeeCommand>
{
    private readonly IEmployeeRepository _repository;
    public UpdateEmployeeCommandValidation(IEmployeeRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Employee must not be null! ")
            .MustAsync(IsEmployeeExist)
            .WithMessage("Employee record does Not Exist!");
    }

    private async Task<bool> IsEmployeeExist(Guid id, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.EmployeeId == id, cancellationToken);
        return result.Value;
    }
}
