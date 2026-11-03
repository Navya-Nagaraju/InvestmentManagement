using InvestManagement.Domain.Entities;
using InvestmentManagement.Application.Interfaces.Repositories;
using InvestmentManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentManagement.Infrastructure.Repositories
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly InvestmentManagementDbContext _context;
        
        public PortfolioRepository(InvestmentManagementDbContext context)
        {
            _context = context;
        }
        public async Task<InvestManagement.Domain.Entities.Portfolio> AddAsync(Portfolio portfolio)
        {
            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
            return portfolio;
        }

        public async Task<List<Portfolio>> GetAllAsync()
        {
            return await _context.Portfolios.ToListAsync();
        }

        public async Task<Portfolio?> GetByIdAsync(int id)
        {
            return await _context.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
