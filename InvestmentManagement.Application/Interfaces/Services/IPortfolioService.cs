using InvestmentManagement.Application.DTOs.Portfolios;

namespace InvestmentManagement.Application.Interfaces.Services
{
    public interface IPortfolioService
    {
        Task<PortfolioResponse> CreateAsync(CreatePortfolioRequest request);
        Task<List<PortfolioResponse>> GetAllAsync();
        Task<PortfolioResponse?> GetByIdAsync(int id);
    }
}
