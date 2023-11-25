using Application.Activities.Handlers;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Seeds;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Database Context to Dependency Injection container
// Connection String defined at appsettings
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// CORS Policy
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://127.0.0.1:5173", "http://localhost:5173");
    });
});

// MediatR
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(GetActivitiesListHandler).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

// Temporary scoped access to Service Container
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

// Execute Db Migrations & Seed before execution
try
{
    var context = services.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
    await ActivitySeed.SeedData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error ocurred during migration");
}

app.Run();
