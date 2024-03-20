using UltracarAPI.Models;
using System.Linq;

namespace UltracarAPI.Repositories.Interfaces
{
    public interface IBudgetRepository : IRepository<Budget>
    {
        Task<Budget> GetByIdAsync(int id);
    }
}
