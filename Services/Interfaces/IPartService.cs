using UltracarAPI.Models;

namespace UltracarAPI.Services.Interfaces
{
    public interface IPartService
    {
        Task<IQueryable<Part>> GetAllPartsAsync();
        Task<Part> GetPartByIdAsync(int id);
        void AddPartAsync(Part part);
        void UpdatePartAsync(Part part);
        void DeletePartAsync(int id);
    }
}
