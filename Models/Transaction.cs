namespace PersonalFinanceBoss.Models
{
    public class Transaction
    {
        public string Description { get; set; } = string.Empty; // Initialize to an empty string
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public string Category { get; set; } = string.Empty; // Initialize to an empty string
        public DateTime Date { get; set; } = DateTime.Now;
    }
}