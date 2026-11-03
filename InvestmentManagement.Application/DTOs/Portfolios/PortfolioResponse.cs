using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentManagement.Application.DTOs.Portfolios;

public class PortfolioResponse
{
    public int Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public decimal CashBalance { get; set; }
    public string Status { get; set; } = string.Empty;

}
