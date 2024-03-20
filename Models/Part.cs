namespace UltracarAPI.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public List<StockMovement> StockMovements { get; set; }
    }
}
