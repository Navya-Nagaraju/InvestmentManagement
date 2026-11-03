using InvestManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentManagement.Application.Interfaces.Repositories
{
    public interface IPortfolioRepository
    {
        Task<Portfolio> AddAsync(Portfolio portfolio);
        Task<List<Portfolio>>GetAllAsync();
        Task<Portfolio?> GetByIdAsync(int id);
    }
}
