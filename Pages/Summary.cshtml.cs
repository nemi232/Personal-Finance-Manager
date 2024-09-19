using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalFinanceBoss.Models;
using PersonalFinanceBoss.Services;
using System.Collections.Generic;

namespace PersonalFinanceBoss.Pages
{
    public class SummaryModel : PageModel
    {
        private readonly FinanceService _financeService;

        public SummaryModel(FinanceService financeService)
        {
            _financeService = financeService;
        }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance { get; set; }

        public void OnGet()
        {
            // Fetching all transactions
            Transactions = _financeService.GetTransactions();

            // Calculating the totals
            TotalIncome = CalculateTotalIncome();
            TotalExpense = CalculateTotalExpense();
            Balance = TotalIncome - TotalExpense;
        }

        private decimal CalculateTotalIncome()
        {
            // Summing all income transactions
            return _financeService.GetTransactions()
                .Where(t => t.IsIncome)
                .Sum(t => t.Amount);
        }

        private decimal CalculateTotalExpense()
        {
            // Summing all expense transactions
            return _financeService.GetTransactions()
                .Where(t => !t.IsIncome)
                .Sum(t => t.Amount);
        }
    }
}