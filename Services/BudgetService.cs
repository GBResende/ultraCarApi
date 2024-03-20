using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Services.Interfaces;

namespace UltracarAPI.Services
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetRepository _budgetRepository;

        public BudgetService(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public Task<IQueryable<Budget>> GetAllBudgetsAsync()
        {
            return _budgetRepository.GetAllAsync();
        }

        public async Task<Budget> GetBudgetByIdAsync(int id)
        {
            return await _budgetRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddBudgetAsync(Budget budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException(nameof(budget));
            }

            return await _budgetRepository.AddAsync(budget);
        }

        public void UpdateBudgetAsync(Budget budget)
        {
            if (budget == null)
            {
                throw new ArgumentNullException(nameof(budget));
            }

            _budgetRepository.UpdateAsync(budget);
        }

        public async void DeleteBudgetAsync(int id)
        {
            var budget = await _budgetRepository.GetByIdAsync(id);
            if (budget == null)
            {
                throw new NullReferenceException("Budget not found.");
            }

            _budgetRepository.DeleteAsync(budget);
        }
    }
}
