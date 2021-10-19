using InmoCRM.Api.Config;
using InmoCRM.Api.Models;

namespace InmoCRM.Api.Repositories.Impl
{
    public class AssetsRepositoryImpl : Repository<Asset>, IAssetsRepository
    {
        public AssetsRepositoryImpl(InmoCRMContext context) : base(context)
        {
        }
    }
}
