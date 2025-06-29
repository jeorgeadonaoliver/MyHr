namespace myHr.persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddDbContext<MyHrIdentityDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MyHrIdentityConnection")));

        services.AddDbContext<MyHrDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MyHrDbConnection")));

        services.AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 8;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            options.User.RequireUniqueEmail = true;
        })
         .AddEntityFrameworkStores<MyHrIdentityDbContext>()
         .AddDefaultTokenProviders();
         //.AddClaimsPrincipalFactory<ApplicationUserClaimsPrincipalFactory>(); ;

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUserRepository, UserRepositoryRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IJobPositionRepository, JobPositionRepository>();
        services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
        services.AddScoped<ILeaveCreditRepository, LeaveCreditRepository>();
        services.AddScoped<IPerformanceEvaluationRepository, PerformanceEvaluationRepository>();
        services.AddScoped<IAttendanceRepository, AttendanceRepository>();

        return services;
    }
}
