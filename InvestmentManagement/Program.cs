using Microsoft.EntityFrameworkCore;
using InvestmentManagement.Infrastructure.Data;
using InvestmentManagement.Application.Interfaces.Repositories;
using InvestmentManagement.Application.Interfaces.Services;
using InvestmentManagement.Application.Services;
using InvestmentManagement.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InvestmentManagementDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Repository
builder.Services.AddScoped<IPortfolioRepository, PortfolioRepository>();

// Register Service
builder.Services.AddScoped<IPortfolioService, PortfolioService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
