//using UltracarAPI.Data;
//using UltracarAPI.Models;
//using UltracarAPI.Repositories.Interfaces;

//namespace UltracarAPI.Repositories
//{
//    public class StockMovementRepository : IStockMovementRepository
//    {
//        private readonly AppDbContext _context;

//        public StockMovementRepository(AppDbContext context)
//        {
//            _context = context;
//        }

//        public IQueryable<StockMovement> GetAll()
//        {
//            return _context.StockMovements;
//        }

//        public StockMovement GetById(int id)
//        {
//            return _context.StockMovements.FirstOrDefault(m => m.Id == id);
//        }

//        public void Add(StockMovement stockMovement)
//        {
//            if (stockMovement == null)
//            {
//                throw new ArgumentNullException(nameof(stockMovement));
//            }

//            _context.StockMovements.Add(stockMovement);
//            _context.SaveChanges();
//        }

//        public void Update(StockMovement stockMovement)
//        {
//            if (stockMovement == null)
//            {
//                throw new ArgumentNullException(nameof(stockMovement));
//            }

//            _context.StockMovements.Update(stockMovement);
//            _context.SaveChanges();
//        }

//        public void Delete(StockMovement stockMovement)
//        {
//            if (stockMovement == null)
//            {
//                throw new ArgumentNullException(nameof(stockMovement));
//            }

//            _context.StockMovements.Remove(stockMovement);
//            _context.SaveChanges();
//        }
//    }
//}
