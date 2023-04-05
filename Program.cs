using BackendAternaNet.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AddDBContext(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void AddDBContext(WebApplicationBuilder builder)
{
    string connectionString = builder.Configuration.GetConnectionString("mssql");
    builder.Services.AddDbContext<AlternaDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });
    builder.Services.AddScoped<DbContext, AlternaDbContext>();
}