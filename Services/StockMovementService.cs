using System.Text.Json.Serialization;
using System.Text.Json;
using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Services.Interfaces;

namespace UltracarAPI.Services
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IStockMovementRepository _stockMovementRepository;

        public StockMovementService(IStockMovementRepository stockMovementRepository)
        {
            _stockMovementRepository = stockMovementRepository;
        }

        public async Task<IQueryable<StockMovement>> GetAllStockMovementsAsync()
        {
            return await _stockMovementRepository.GetAllAsync();
        }

        public async Task<StockMovement> GetStockMovementByIdAsync(int id)
        {

            var stockMovementWithDetails = await _stockMovementRepository.GetByIdAsync(id);

            return stockMovementWithDetails;
        }

        public Task<bool> AddStockMovementAsync(StockMovement stockMovement)
        {
            if (stockMovement == null)
            {
                throw new ArgumentNullException(nameof(stockMovement));
            }

            return _stockMovementRepository.AddAsync(stockMovement);
        }

        public async Task UpdateStockMovementAsync(StockMovement stockMovement)
        {
            if (stockMovement == null)
            {
                throw new ArgumentNullException(nameof(stockMovement));
            }

            await _stockMovementRepository.UpdateAsync(stockMovement);
        }

        public async void DeleteStockMovementAsync(int id)
        {
            var stockMovement = await _stockMovementRepository.GetByIdAsync(id);
            if (stockMovement == null)
            {
                throw new NullReferenceException("Stock movement not found.");
            }

            _stockMovementRepository.DeleteAsync(stockMovement);
        }
    }
}
