using InmoCRM.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmoCRM.Api.Services
{
    public interface IAssetsService
    {
        IEnumerable<Asset> GetAssets();
    }
}
