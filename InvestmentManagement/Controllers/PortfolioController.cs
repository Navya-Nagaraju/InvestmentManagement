using InvestmentManagement.Application.DTOs.Portfolios;
using InvestmentManagement.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PortfolioController : ControllerBase
{
    private readonly IPortfolioService _portfolioService;

    public PortfolioController(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePortfolio([FromBody] CreatePortfolioRequest request)
    {
        var response = await _portfolioService.CreateAsync(request);
        return StatusCode(201, response);
    }

    [HttpGet]
    public async Task<ActionResult<List<PortfolioResponse>>> GetAll()
    {
        var portfolios = await _portfolioService.GetAllAsync();
        return Ok(portfolios);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var portfolio = await _portfolioService.GetByIdAsync(id);
        if (portfolio == null)
        {
            return NotFound();
        }
        return Ok(portfolio);
    }
}
