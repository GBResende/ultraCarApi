using UltracarAPI.Models;
using UltracarAPI.Services.Interfaces;
using UltracarAPI.UseCases.Interfaces;
using UltracarAPI.Utils.Dtos;
using UltracarAPI.Utils.Enums;
using UltracarAPI.Utils.Mapper;

namespace UltracarAPI.UseCases
{
    public class SettleBudgetUseCase : ISettleBudgetUseCase
    {
        private readonly IStockMovementService _stockMovementService;
        private readonly IPartService _partService;

        public SettleBudgetUseCase(IStockMovementService stockMovementService, IPartService partService)
        {
            _stockMovementService = stockMovementService;
            _partService = partService;
        }

        public async Task<bool> ExecuteAsync(int stockMovementId)
        {
            try
            {
                var stockMovementFounded = await _stockMovementService.GetStockMovementByIdAsync(stockMovementId);

                if (stockMovementFounded is null)
                {
                    throw new Exception("Stock Movement not found");
                }

                if (stockMovementFounded.MovementType != MovementType.awaiting)
                {
                    throw new Exception("Your budget is not ready");
                }

                var partFounded = await _partService.GetPartByIdAsync(stockMovementFounded.PartId);

                if(partFounded.Quantity < stockMovementFounded.Quantity)
                {
                    throw new Exception("requested stock quantity is not available");
                }

                var partModel = new Part()
                {
                    Id = partFounded.Id,
                    Name = partFounded.Name,
                    Quantity = (partFounded.Quantity - stockMovementFounded.Quantity)
                };

                stockMovementFounded.MovementType = MovementType.exit;

                await _partService.UpdatePartAsync(partModel);
                await _stockMovementService.UpdateStockMovementAsync(stockMovementFounded);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
        }
    }
}
