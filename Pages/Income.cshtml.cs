using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalFinanceBoss.Services;

namespace PersonalFinanceBoss.Pages
{
    public class IncomeModel : PageModel
    {
        private readonly FinanceService _financeService;

        public IncomeModel(FinanceService financeService)
        {
            _financeService = financeService;
        }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public decimal Amount { get; set; }

        [BindProperty]
        public string Category { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                _financeService.AddTransaction(Description, Amount, true, Category);
            }
        }
    }
}