namespace myHr.application.Features.Departments.command.create_department
{
    public static class CreateDepartmentCommandExtension
    {
        public static Department MapToDepartment(this CreateDepartmentCommand command) 
        {
            return new Department { 
            
                DepartmentId =command.Id,
                CreatedDate = command.CreatedDate,
                CreatedBy = command.CreatedBy,
                DepartmentName = command.DepartmentName,
                Location = command.Location
            };
        }
    }
}
