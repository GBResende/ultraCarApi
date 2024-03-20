using UltracarAPI.Models;

namespace UltracarAPI.UseCases.Interfaces
{
    public interface ISettleBudgetUseCase
    {
        Task<bool> ExecuteAsync(int stockMovementId);
    }
}
