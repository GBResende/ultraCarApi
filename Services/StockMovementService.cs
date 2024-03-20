//using UltracarAPI.Models;
//using UltracarAPI.Repositories.Interfaces;
//using UltracarAPI.Services.Interfaces;

//namespace UltracarAPI.Services
//{
//    public class StockMovementService : IStockMovementService
//    {
//        private readonly IStockMovementRepository _stockMovementRepository;

//        public StockMovementService(IStockMovementRepository stockMovementRepository)
//        {
//            _stockMovementRepository = stockMovementRepository;
//        }

//        public IQueryable<StockMovement> GetAllStockMovements()
//        {
//            return _stockMovementRepository.GetAll();
//        }

//        public StockMovement GetStockMovementById(int id)
//        {
//            return _stockMovementRepository.GetById(id);
//        }

//        public void AddStockMovement(StockMovement stockMovement)
//        {
//            if (stockMovement == null)
//            {
//                throw new ArgumentNullException(nameof(stockMovement));
//            }

//            _stockMovementRepository.Add(stockMovement);
//        }

//        public void UpdateStockMovement(StockMovement stockMovement)
//        {
//            if (stockMovement == null)
//            {
//                throw new ArgumentNullException(nameof(stockMovement));
//            }

//            _stockMovementRepository.Update(stockMovement);
//        }

//        public void DeleteStockMovement(int id)
//        {
//            var stockMovement = _stockMovementRepository.GetById(id);
//            if (stockMovement == null)
//            {
//                throw new NullReferenceException("Stock movement not found.");
//            }

//            _stockMovementRepository.Delete(stockMovement);
//        }
//    }
//}
