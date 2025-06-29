namespace myHr.persistence.Repository;

public class UserRepositoryRepository : GenericRepository<ApplicationUser>, IUserRepository
{
    public UserRepositoryRepository(MyHrIdentityDbContext _identityContext) : base(_identityContext)
    {
        
    }
}
