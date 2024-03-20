using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Services.Interfaces;
using UltracarAPI.Utils.Dtos;

namespace UltracarAPI.Services
{
    public class PartService : IPartService
    {
        private readonly IPartRepository _partRepository;

        public PartService(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public Task<IQueryable<Part>> GetAllPartsAsync()
        {
            return _partRepository.GetAllAsync();
        }

        public Task<Part> GetPartByIdAsync(int id)
        {
            return _partRepository.GetByIdAsync(id);
        }

        public async Task<bool> AddPartAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return await _partRepository.AddAsync(part);
        }

        public async Task UpdatePartAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            await _partRepository.UpdateAsync(part);
        }

        public async void DeletePartAsync(int id)
        {
            var part = await _partRepository.GetByIdAsync(id);
            if (part == null)
            {
                throw new NullReferenceException("Part not found.");
            }

            _partRepository.DeleteAsync(part);
        }
    }
}
