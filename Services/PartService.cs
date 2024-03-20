using UltracarAPI.Models;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Services.Interfaces;

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

        public void AddPartAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            _partRepository.AddAsync(part);
        }

        public void UpdatePartAsync(Part part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            _partRepository.UpdateAsync(part);
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
