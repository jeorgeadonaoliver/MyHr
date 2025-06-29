using myHr.application.Features.Employees.query.get_employee.by_id;
using myHr.application.Features.Employees.query.GetAllEmployee;
using myHr.domain.myHrDb;

namespace myHr.application.Extension;

public static class EmployeeExtension
{
    public static GetAllEmployeeQueryDto MapToGetAllEmployeeQueryDto(this Employee emp) 
    {
        return new GetAllEmployeeQueryDto() {
        
            Id = emp.EmployeeId,
            CreatedBy = emp.CreatedBy,
            CreatedDate = emp.CreatedDate,
            DepartmentId = emp.DepartmentId,
            Email = emp.Email,
            FirstName = emp.FirstName,
            HireDate = emp.HireDate,
            LastName = emp.LastName,
            ModifiedBy = emp.ModifiedBy,    
            ModifiedDate = emp.ModifiedDate,
            PhoneNumber = emp.PhoneNumber,
            PositionId = emp.PositionId,
            Salary = emp.Salary,
        };
    }

    public static GetEmployeeByIdQueryDto MapToGetEmployeeByIdQuery(this Employee emp) 
    {
        return new GetEmployeeByIdQueryDto() {
         
            Id = emp.EmployeeId,
            CreatedBy = emp.CreatedBy,
            CreatedDate = emp.CreatedDate,
            DepartmentId = emp.DepartmentId,
            Email= emp.Email,
            FirstName= emp.FirstName,
            HireDate= emp.HireDate,
            LastName= emp.LastName,
            ModifiedBy= emp.ModifiedBy,
            ModifiedDate= emp.ModifiedDate,
            PhoneNumber= emp.PhoneNumber,
            PositionId= emp.PositionId,
            Salary= emp.Salary,
        };
    }
}
