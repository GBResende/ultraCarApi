using UltracarAPI.Models;

namespace UltracarAPI.Repositories.Interfaces
{
    public interface IStockMovementRepository : IRepository<StockMovement>
    {
        Task<StockMovement> GetByIdAsync(int stockMovementId);
    }
}
