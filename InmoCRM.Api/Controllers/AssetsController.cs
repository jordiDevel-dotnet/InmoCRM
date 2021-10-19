using InmoCRM.Api.Models;
using InmoCRM.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace InmoCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : CrudController<Asset, IAssetsService>
    {
        public AssetsController(IAssetsService service) : base(service)
        {

        }
    }
}
