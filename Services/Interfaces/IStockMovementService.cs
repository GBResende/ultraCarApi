using UltracarAPI.Models;

namespace UltracarAPI.Services.Interfaces
{
    public interface IStockMovementService
    {
        Task<IQueryable<StockMovement>> GetAllStockMovementsAsync();
        Task<StockMovement> GetStockMovementByIdAsync(int id);
        Task<bool> AddStockMovementAsync(StockMovement stockMovement);
        Task UpdateStockMovementAsync(StockMovement stockMovement);
        void DeleteStockMovementAsync(int id);
    }
}
