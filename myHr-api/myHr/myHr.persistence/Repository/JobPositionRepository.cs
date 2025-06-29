namespace myHr.persistence.Repository;

public class JobPositionRepository : GenericRepository<JobPosition>, IJobPositionRepository
{
    public JobPositionRepository(MyHrDbContext context) : base(context)
    {
        
    }
}
