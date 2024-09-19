using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalFinanceBoss.Services;

namespace PersonalFinanceBoss.Pages
{
    public class ExpenseModel : PageModel
    {
        private readonly FinanceService _financeService;

        public ExpenseModel(FinanceService financeService)
        {
            _financeService = financeService;
        }

        [BindProperty]
        public string Description { get; set; } = string.Empty; // Initialize to an empty string

        [BindProperty]
        public decimal Amount { get; set; }

        [BindProperty]
        public string Category { get; set; } = string.Empty; // Initialize to an empty string

        public void OnPost()
        {
            _financeService.AddTransaction(Description, Amount, false, Category);
        }
    }
}