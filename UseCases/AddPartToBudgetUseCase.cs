using UltracarAPI.Models;
using UltracarAPI.Services.Interfaces;
using UltracarAPI.UseCases.Interfaces;
using UltracarAPI.Utils.Enums;
using UltracarAPI.Utils.Mapper;

namespace UltracarAPI.UseCases
{
    public class AddPartToBudgetUseCase : IAddPartToBudgetUseCase
    {
        private readonly IStockMovementService _stockMovementService;

        public AddPartToBudgetUseCase(IStockMovementService stockMovementService)
        {
            _stockMovementService = stockMovementService;

        }

        public async Task<bool> ExecuteAsync(StockMovement stockMovement)
        {
            try
            {
                var budgets = await _stockMovementService.AddStockMovementAsync(stockMovement);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
        }
    }
}
