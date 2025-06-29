

namespace myHr.persistence.Repository;

public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(MyHrDbContext context): base(context)
    {
        
    }
}