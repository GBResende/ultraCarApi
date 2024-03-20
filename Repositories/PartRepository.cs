using UltracarAPI.Data;
using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Utils.Dtos;

namespace UltracarAPI.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly AppDbContext _context;

        public PartRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<Part>> GetAllAsync()
        {
            return _context.Parts;
        }

        public async Task<Part> GetByIdAsync(int id)
        {

            return _context.Parts.FirstOrDefault(p => p.Id == id);

        }

        public async Task<bool> AddAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            _context.Parts.Add(part);
            _context.SaveChanges();

            return true;
        }

        public async Task UpdateAsync(Part part)
        {
            var partForUpdate = await _context.Parts.FindAsync(part.Id);

            if (partForUpdate != null)
            {
                partForUpdate.Name = part.Name;
                partForUpdate.Quantity = part.Quantity;
                await _context.SaveChangesAsync();
            }
        }

        public void DeleteAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            _context.Parts.Remove(part);
            _context.SaveChanges();
        }
    }
}
