namespace myHr.security.myHrIdentityDb;

public class MyHrIdentityDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>, Guid>
{
    public MyHrIdentityDbContext(DbContextOptions<MyHrIdentityDbContext> options)
    : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
