using UltracarAPI.Models;
using UltracarAPI.Utils.Dtos;

namespace UltracarAPI.Services.Interfaces
{
    public interface IPartService
    {
        Task<IQueryable<Part>> GetAllPartsAsync();
        Task<Part> GetPartByIdAsync(int id);
        Task<bool> AddPartAsync(Part part);
        Task UpdatePartAsync(Part part);
        void DeletePartAsync(int id);
    }
}
