namespace myHr.application.Features.Employees.Command.create_employee
{
    public static class CreateEmployeeCommandExtension
    {
        public static Employee MapToEmployee(this CreateEmployeeCommand cmd) 
        {
            return new Employee {
            
                EmployeeId = cmd.Id,
                CreatedBy = cmd.CreatedBy,
                CreatedDate = cmd.CreatedDate,
                DepartmentId = cmd.DepartmentId,
                Email = cmd.Email,
                FirstName = cmd.FirstName,
                HireDate = cmd.HireDate,
                PhoneNumber = cmd.PhoneNumber,
                PositionId = cmd.PositionId,
                Salary = cmd.Salary,
                LastName = cmd.LastName
            };
        }
    }
}
