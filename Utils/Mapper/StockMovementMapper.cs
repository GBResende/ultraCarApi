using UltracarAPI.Models;
using UltracarAPI.Utils.Dtos;

namespace UltracarAPI.Utils.Mapper
{
    public static class StockMovementMapper
    {
        public static StockMovementDto MapToDto(StockMovement stockMovement)
        {
            if (stockMovement == null)
            {
                return null;
            }

            return new StockMovementDto
            {
                Id = stockMovement.Id,
                PartId = stockMovement.PartId,
                Part = new PartDto
                {
                    Id = stockMovement.Part.Id,
                    Name = stockMovement.Part.Name,
                    Quantity = stockMovement.Part.Quantity
                },
                Quantity = stockMovement.Quantity,
                BudgetId = stockMovement.BudgetId,
                Budget = new BudgetDto
                {
                    Id = stockMovement.Budget.Id,
                    VehiclePlate = stockMovement.Budget.VehiclePlate,
                    CustomerName = stockMovement.Budget.CustomerName
                },
                MovementType = stockMovement.MovementType
            };
        }
    }
}
