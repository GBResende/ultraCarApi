using UltracarAPI.Utils.Enums;

namespace UltracarAPI.Models
{
    public class StockMovement
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int Quantity { get; set; }
        public int BudgetId { get; set; }
        public Budget Budget { get; set; }
        public MovementType MovementType { get; set; }
    }
}
