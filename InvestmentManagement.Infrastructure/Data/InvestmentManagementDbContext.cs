using InvestManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentManagement.Infrastructure.Data;

public class InvestmentManagementDbContext : DbContext
{
    public InvestmentManagementDbContext(DbContextOptions<InvestmentManagementDbContext> options) : base(options)
    {
    }
    public DbSet<Portfolio> Portfolios { get; set; }
}
