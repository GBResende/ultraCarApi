using UltracarAPI.Models;

namespace UltracarAPI.Services.Interfaces
{
    public interface IBudgetService
    {
        Task<IQueryable<Budget>> GetAllBudgetsAsync();
        Task<Budget> GetBudgetByIdAsync(int id);
        Task<bool> AddBudgetAsync(Budget budget);
        void UpdateBudgetAsync(Budget budget);
        void DeleteBudgetAsync(int id);
    }
}
