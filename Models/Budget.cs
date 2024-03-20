namespace UltracarAPI.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string VehiclePlate { get; set; }
        public string CustomerName { get; set; }
        public List<StockMovement> StockMovements { get; set; }
    }

}
