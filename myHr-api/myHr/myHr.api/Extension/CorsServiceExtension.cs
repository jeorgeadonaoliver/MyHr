namespace myHr.api.Extension
{
    public static class CorsServiceExtension
    {
        public static IServiceCollection AddCorsService(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalHost4200",
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:4200")
                               .AllowAnyMethod()
                               .AllowAnyHeader()
                               .AllowCredentials();
                    });

                //options.AddDefaultPolicy(
                //    policy => {
                //        policy.WithOrigins("http://localhost:4200") // <-- Your Angular App's URL
                //          .AllowAnyHeader()
                //          .AllowAnyMethod();
                //    });
            });
            return services;
        }
    }
}
