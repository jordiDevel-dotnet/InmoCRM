using InmoCRM.Api.Dtos;
using InmoCRM.Api.Extensions;
using InmoCRM.Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InmoCRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetsService service;

        public AssetsController(IAssetsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<AssetDto> GetAssets()
        {
            var assets = (this.service.GetAssets()).Select(asset => asset.AsDto());

            return assets;
        }
    }
}
