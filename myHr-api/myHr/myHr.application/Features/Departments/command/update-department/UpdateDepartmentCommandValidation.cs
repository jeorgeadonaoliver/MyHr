using FluentValidation;

namespace myHr.application.Features.Departments.command.update_department;

public class UpdateDepartmentCommandValidation : AbstractValidator<UpdateDepartmentCommand>
{
    private readonly IDepartmentRepository _repository;

    public UpdateDepartmentCommandValidation(IDepartmentRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Department Id must not be null!")
            .MustAsync(IsDepartmentIdExist)
            .WithMessage("Department Id does not exist!"); ;

        RuleFor(x => x.DepartmentName)
            .NotNull()
            .WithMessage("Department name is required!")
            .MustAsync(IsDepartmentNameExist)
            .WithMessage("Department name does already exist!"); ;
    }

    private async Task<bool> IsDepartmentNameExist(string name, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.DepartmentName == name, cancellationToken);
        return !result.Value;
    }

    private async Task<bool> IsDepartmentIdExist(Guid id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAnyAsync(x => x.DepartmentId == id, cancellationToken);
        return result.Value;
    }
}
