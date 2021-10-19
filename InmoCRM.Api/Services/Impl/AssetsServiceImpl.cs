using InmoCRM.Api.Models;
using InmoCRM.Api.Repositories;
using System.Collections.Generic;

namespace InmoCRM.Api.Services.Impl
{
    public class AssetsServiceImpl : IAssetsService
    {
        private readonly IAssetsRepository repository;

        public AssetsServiceImpl(IAssetsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Asset> GetAssets()
        {
            return this.repository.GetAll();
        }
    }
}
