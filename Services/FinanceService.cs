using PersonalFinanceBoss.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceBoss.Services
{
    public class FinanceService
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();

        public void AddTransaction(string description, decimal amount, bool isIncome, string category)  // Add category parameter
        {
            _transactions.Add(new Transaction
            {
                Description = description,
                Amount = amount,
                IsIncome = isIncome,
                Category = category,  // Store category
                Date = DateTime.Now
            });
        }

        public List<Transaction> GetTransactions() => _transactions;
    }
}