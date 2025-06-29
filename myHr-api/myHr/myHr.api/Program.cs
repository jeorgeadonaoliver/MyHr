var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddSecurityService(builder.Configuration);
builder.Services.AddJwtSettingsService(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddSwaggerDocumentation();

builder.Services.AddGraphQLService();

builder.Services.AddSingleton<ICookieService, CookieService>();

builder.Services.AddControllers();
builder.Services.AddCorsService();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

#region seeding 
//builder.Services.AddScoped<IdentitySeeder>();

//using (var scope = app.Services.CreateScope())
//{
//    var seeder = scope.ServiceProvider.GetRequiredService<IdentitySeeder>();
//    await seeder.SeedAsync();
//}

#endregion


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        c.RoutePrefix = string.Empty;
    });
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowLocalHost4200");

app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseMiddleware<HeaderLoggingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
