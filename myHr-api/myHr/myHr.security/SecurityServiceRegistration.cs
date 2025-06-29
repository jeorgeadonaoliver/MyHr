namespace myHr.security;

public static class SecurityServiceRegistration 
{
    public static IServiceCollection AddSecurityService(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddScoped<IJwtService, JwtService>();

        services.ConfigureApplicationCookie(options =>
        {

            options.Cookie.HttpOnly = true;
            options.Cookie.SecurePolicy = CookieSecurePolicy.None; 
            options.Cookie.SameSite = SameSiteMode.Lax;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(1440); 
            //options.LoginPath = "/Account/Login"; 
            //options.AccessDeniedPath = "/Account/AccessDenied";
            options.SlidingExpiration = true; 
            options.Cookie.Name = "authTokenServer";
        });

        return services;
    }
}
