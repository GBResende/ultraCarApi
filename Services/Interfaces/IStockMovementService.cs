using UltracarAPI.Models;

namespace UltracarAPI.Services.Interfaces
{
    public interface IStockMovementService
    {
        IQueryable<StockMovement> GetAllStockMovements();
        StockMovement GetStockMovementById(int id);
        void AddStockMovement(StockMovement stockMovement);
        void UpdateStockMovement(StockMovement stockMovement);
        void DeleteStockMovement(int id);
    }
}
