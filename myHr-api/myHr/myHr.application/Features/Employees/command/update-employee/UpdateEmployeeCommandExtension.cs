using myHr.application.Features.Employees.Command.update_employee;

namespace myHr.application.Features.Employees.command.update_employee;

public static class UpdateEmployeeCommandExtension
{
    public static Employee MapToEmployee(this UpdateEmployeeCommand cmd) 
    {
        return new Employee 
        {
            EmployeeId = cmd.Id,
            CreatedBy = cmd.CreatedBy,
            CreatedDate = cmd.CreatedDate,
            DepartmentId = cmd.DepartmentId,
            Email = cmd.Email,
            FirstName = cmd.FirstName,
            LastName = cmd.LastName,
            HireDate = cmd.HireDate,
            ModifiedDate = cmd.ModifiedDate,
            ModifiedBy = cmd.ModifiedBy,
            PositionId = cmd.PositionId,
            Salary = cmd.Salary,
            PhoneNumber = cmd.PhoneNumber,
        };
    }
}
