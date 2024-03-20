namespace UltracarAPI.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> AddAsync(T entity);
        Task UpdateAsync(T entity);
        void DeleteAsync(T entity);
    }
}
