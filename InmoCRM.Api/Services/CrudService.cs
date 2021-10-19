using InmoCRM.Api.Models;
using InmoCRM.Api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InmoCRM.Api.Services
{
    public abstract class CrudService<TEntity, TRepository> : ICrudService<TEntity>
        where TEntity : class, IEntity
        where TRepository : class, IRepository<TEntity>
    {
        public readonly IRepository<TEntity> repository;

        public CrudService(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public Task<TEntity> Add(TEntity entity)
        {
            return this.repository.Add(entity);
        }

        public Task<TEntity> Delete(int id)
        {
            return this.repository.Delete(id);
        }

        public Task<TEntity> Get(int id)
        {
            return this.repository.Get(id);
        }

        public Task<List<TEntity>> GetAll()
        {
            return this.repository.GetAll();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            return this.repository.Update(entity);
        }
    }
}
