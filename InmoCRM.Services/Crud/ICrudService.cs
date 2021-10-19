using InmoCRM.Models.Crud;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InmoCRM.Services.Crud
{
    public interface ICrudService<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
