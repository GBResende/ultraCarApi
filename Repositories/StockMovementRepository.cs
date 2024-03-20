using Microsoft.EntityFrameworkCore;
using UltracarAPI.Data;
using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;

namespace UltracarAPI.Repositories
{
    public class StockMovementRepository : IStockMovementRepository
    {
        private readonly AppDbContext _context;

        public StockMovementRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<StockMovement>> GetAllAsync()
        {
            return _context.StockMovements;
        }

        public async Task<StockMovement> GetByIdAsync(int id)
        {
            var stockMovementWithDetails = _context.StockMovements
                .Where(sm => sm.Id == id)
                .Include(sm => sm.Part) 
                .Include(sm => sm.Budget)
                .FirstOrDefault();

            if (stockMovementWithDetails == null)
            {
                throw new ArgumentNullException();
            }

            return stockMovementWithDetails;
        }

        public async Task<bool> AddAsync(StockMovement stockMovement)
        {
            if (stockMovement == null)
            {
                throw new ArgumentNullException(nameof(stockMovement));
            }

            _context.StockMovements.Add(stockMovement);
            _context.SaveChanges();

            return true;
        }

        public async Task UpdateAsync(StockMovement stockMovement)
        {

            var stockMovementToUpdate = await _context.StockMovements.FindAsync(stockMovement.Id);

            if (stockMovementToUpdate != null)
            {
                stockMovementToUpdate.MovementType = stockMovement.MovementType;

                await _context.SaveChangesAsync();
            }

        }

        public void DeleteAsync(StockMovement stockMovement)
        {
            if (stockMovement == null)
            {
                throw new ArgumentNullException(nameof(stockMovement));
            }

            _context.StockMovements.Remove(stockMovement);
            _context.SaveChanges();
        }
    }
}
