using UltracarAPI.Models;
using UltracarAPI.Utils.Enums;

namespace UltracarAPI.Utils.Dtos
{
    public class StockMovementDto
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public PartDto Part { get; set; }
        public int Quantity { get; set; }
        public int BudgetId { get; set; }
        public BudgetDto Budget { get; set; }
        public MovementType MovementType { get; set; }
    }

}
