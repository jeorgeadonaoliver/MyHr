namespace myHr.persistence.Repository;

public class LeaveCreditRepository : GenericRepository<LeaveCredit>, ILeaveCreditRepository
{
    public LeaveCreditRepository(MyHrDbContext context) : base(context)
    {
        
    }
}
