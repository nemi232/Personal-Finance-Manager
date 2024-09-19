using System.Collections.Generic;
using PersonalFinanceBoss.Models;

namespace PersonalFinanceBoss.Services
{
    public class CategoryService
    {
        private List<Category> _categories = new List<Category>
        {
            new Category { Id = 1, Name = "Rent" },
            new Category { Id = 2, Name = "Groceries" },
            new Category { Id = 3, Name = "Salary" },
            // Add more default categories as needed
        };

        public List<Category> GetCategories() => _categories;
    }
}