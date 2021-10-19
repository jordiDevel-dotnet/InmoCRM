using InmoCRM.Api.Models;
using InmoCRM.Api.Repositories;

namespace InmoCRM.Api.Services.Impl
{
    public class AssetsServiceImpl : CrudService<Asset, IAssetsRepository>, IAssetsService
    {
        public AssetsServiceImpl(IAssetsRepository repository) : base(repository)
        {

        }
    }
}
