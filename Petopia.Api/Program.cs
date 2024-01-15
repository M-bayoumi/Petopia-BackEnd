using Microsoft.EntityFrameworkCore;
using Petopia.Core;
using Petopia.infrastructure.Data;
using Petopia.Infrastructure;
using Petopia.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database
var constr = builder.Configuration.GetConnectionString("constr");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(constr);
});
#endregion

builder.Services
    .AddInfrastructureDependencies()
    .AddServiceDependencies()
    .AddCoreDependencies();

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
