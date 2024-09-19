using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalFinanceBoss.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceBoss.Pages
{
    public class MonthlyReportModel : PageModel
    {
        private readonly FinanceService _financeService;

        public MonthlyReportModel(FinanceService financeService)
        {
            _financeService = financeService;
        }

        public List<MonthlyReport> MonthlyReports { get; private set; }

        public void OnGet()
        {
            var allTransactions = _financeService.GetTransactions();

            // Group transactions by Year and Month
            MonthlyReports = allTransactions
                .GroupBy(t => new { t.Date.Year, t.Date.Month })
                .Select(g => new MonthlyReport
                {
                    Month = $"{g.Key.Month}/{g.Key.Year}",  // Format as "Month/Year" (e.g., "9/2024")
                    TotalIncome = g.Where(t => t.IsIncome).Sum(t => t.Amount),
                    TotalExpenses = g.Where(t => !t.IsIncome).Sum(t => t.Amount),
                    Savings = g.Where(t => t.IsIncome).Sum(t => t.Amount) - g.Where(t => !t.IsIncome).Sum(t => t.Amount)
                })
                .ToList();
        }
    }

    public class MonthlyReport
    {
        public string Month { get; set; }  // e.g., "September 2024"
        public decimal TotalIncome { get; set; }  // Sum of income transactions
        public decimal TotalExpenses { get; set; }  // Sum of expense transactions
        public decimal Savings { get; set; }  // Income - Expenses
    }
}