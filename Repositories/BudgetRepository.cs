using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using UltracarAPI.Data;
using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;

namespace UltracarAPI.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly AppDbContext _context;

        public BudgetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Budget>> GetAllAsync()
        {
            return _context.Budgets;
        }

        public async Task<Budget> GetByIdAsync(int id)
        {
            return await _context.Budgets.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<bool> AddAsync(Budget budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException(nameof(budget));
            }

            _context.Budgets.Add(budget);
            _context.SaveChanges();

            return true;
        }

        public async Task UpdateAsync(Budget budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException(nameof(budget));
            }

            _context.Budgets.Update(budget);
            _context.SaveChanges();
        }

        public void DeleteAsync(Budget budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException(nameof(budget));
            }

            _context.Budgets.Remove(budget);
            _context.SaveChanges();
        }

        
    }

}
