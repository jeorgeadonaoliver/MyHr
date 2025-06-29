namespace myHr.persistence.Repository;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(MyHrDbContext context) : base(context)
    {
        
    }
}
