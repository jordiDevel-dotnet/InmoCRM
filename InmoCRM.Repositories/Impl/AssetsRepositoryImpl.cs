using InmoCRM.Models;
using InmoCRM.Repositories.Config;
using InmoCRM.Repositories.Crud;

namespace InmoCRM.Repositories.Impl
{
    public class AssetsRepositoryImpl : Repository<Asset, InmoCRMContext>, IAssetsRepository
    {
        public AssetsRepositoryImpl(InmoCRMContext context) : base(context)
        {
        }
    }
}
