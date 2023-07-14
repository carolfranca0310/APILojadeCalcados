using Domain.Entity;

namespace Repository.Interface
{
    public interface IBaseRepository <T> where T : BaseDomain
    {
        Task<T> GetById (int id);
        Task<List<T>> GetAll();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(int id);
    }
}
