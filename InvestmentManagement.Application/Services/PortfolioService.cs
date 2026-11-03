using InvestManagement.Domain.Entities;
using InvestmentManagement.Application.DTOs.Portfolios;
using InvestmentManagement.Application.Interfaces.Repositories;
using InvestmentManagement.Application.Interfaces.Services;

namespace InvestmentManagement.Application.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;

        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public async Task<PortfolioResponse> CreateAsync(CreatePortfolioRequest request)
        {
            // Convert Request DTO into Portfolio Entity
            var portfolio = new Portfolio
            {
                Name = request.Name,
                CashBalance = request.CashBalance
            };

            // Save portfolio
            var createdPortfolio = await _portfolioRepository.AddAsync(portfolio);

            // Convert Entity into Response DTO
            var response = new PortfolioResponse
            {
                Id = createdPortfolio.Id,
                Name = createdPortfolio.Name,
                CashBalance = createdPortfolio.CashBalance,
                Status = createdPortfolio.Status.ToString()
            };

            return response;
        }

        public async Task<List<PortfolioResponse>> GetAllAsync()
        {
            // Retrieve all portfolios from the repository
            var portfolios = await _portfolioRepository.GetAllAsync();

            // Convert each Portfolio entity into a response DTO
            var response = portfolios.Select(portfolio => new PortfolioResponse
            {
                Id = portfolio.Id,
                Name = portfolio.Name,
                CashBalance = portfolio.CashBalance,
                Status = portfolio.Status.ToString()
            }).ToList();

            return response;
        }

        public async Task<PortfolioResponse?> GetByIdAsync(int id)
        {
            // Retrieve the portfolio from the repository
            var portfolio = await _portfolioRepository.GetByIdAsync(id);

            if (portfolio == null)
            {
                return null;
            }

            // Convert the Portfolio entity into a response DTO
            var response = new PortfolioResponse
            {
                Id = portfolio.Id,
                Name = portfolio.Name,
                CashBalance = portfolio.CashBalance,
                Status = portfolio.Status.ToString()
            };

            return response;
        }
    }
}
       