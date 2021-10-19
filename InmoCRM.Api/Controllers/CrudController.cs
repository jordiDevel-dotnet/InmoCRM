using InmoCRM.Api.Models;
using InmoCRM.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InmoCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CrudController<TEntity, TService> : ControllerBase
        where TEntity : class, IEntity
        where TService : ICrudService<TEntity>
    {
        private readonly TService service;

        public CrudController(TService service)
        {
            this.service = service;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await this.service.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await this.service.Get(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await this.service.Update(entity);

            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await this.service.Add(entity);

            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await this.service.Delete(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }
    }
}
