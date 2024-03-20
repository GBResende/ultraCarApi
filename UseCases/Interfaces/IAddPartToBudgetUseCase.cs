using UltracarAPI.Models;

namespace UltracarAPI.UseCases.Interfaces
{
    public interface IAddPartToBudgetUseCase
    {
        Task<bool> ExecuteAsync(StockMovement stockMovement);
    }
}
