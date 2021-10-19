using InmoCRM.Models;
using InmoCRM.Services;
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
