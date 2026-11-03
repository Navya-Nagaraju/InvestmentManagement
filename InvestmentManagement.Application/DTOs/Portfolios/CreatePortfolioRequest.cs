using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InvestmentManagement.Application.DTOs.Portfolios;

public class CreatePortfolioRequest
{
    [Required(ErrorMessage = "Portfolio name is required.")]
    [StringLength(100, ErrorMessage = "Portfolio name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Range(typeof(decimal), "0", "79228162514264337593543950335",
            ErrorMessage = "Cash balance cannot be negative.")]
    public decimal CashBalance { get; set; }    
}
