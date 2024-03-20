using UltracarAPI.Models;

namespace UltracarAPI.Repositories.Interfaces
{
    public interface IPartRepository : IRepository<Part>
    {
        Task<Part> GetByIdAsync(int partId);
    }
}
