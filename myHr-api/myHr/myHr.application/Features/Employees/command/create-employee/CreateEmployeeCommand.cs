﻿
namespace myHr.application.Features.Employees.Command.create_employee;

public class CreateEmployeeCommand : BaseDto, IRequest<Result<Guid>>
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateOnly HireDate { get; set; }

    public decimal Salary { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? DepartmentId { get; set; }
}
