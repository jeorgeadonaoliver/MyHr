namespace myHr.persistence.Repository;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    public LeaveRequestRepository(MyHrDbContext context) : base(context)
    {
        
    }
}
