namespace myHr.application.Features.Departments.command.create_department;

public class CreateDepartmentCommandValidation : AbstractValidator<CreateDepartmentCommand>
{
    private readonly IDepartmentRepository _repository;

    public CreateDepartmentCommandValidation(IDepartmentRepository repository)
    {
        _repository = repository;

        RuleFor(x => x.DepartmentName)
            .NotNull().WithMessage("Department name is required!");

        RuleFor(x => x.Location)
            .NotNull().WithMessage("Location is required!");

        RuleFor(x => x)
            .NotNull()
            .WithMessage("Department ID must not be null! ")
            .MustAsync(IsDepartmentExist)
            .WithMessage("Department Already Exist! ");
    }

    private async Task<bool> IsDepartmentExist(CreateDepartmentCommand cmd, CancellationToken cancellationToken) 
    {
        var result = await _repository.GetAnyAsync(x => x.DepartmentId == cmd.Id || x.DepartmentName == cmd.DepartmentName, cancellationToken);
        return !result.Value;
    }

}
