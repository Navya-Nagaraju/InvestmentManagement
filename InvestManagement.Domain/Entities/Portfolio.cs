using InvestManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestManagement.Domain.Entities
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal CashBalance { get; set; }
        public PortfolioStatus Status { get; set; } = PortfolioStatus.Active;
    }
}
