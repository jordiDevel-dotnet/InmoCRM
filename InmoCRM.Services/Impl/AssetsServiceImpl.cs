using InmoCRM.Models;
using InmoCRM.Repositories;
using InmoCRM.Services.Crud;

namespace InmoCRM.Services.Impl
{
    public class AssetsServiceImpl : CrudService<Asset, IAssetsRepository>, IAssetsService
    {
        public AssetsServiceImpl(IAssetsRepository repository) : base(repository)
        {

        }
    }
}
