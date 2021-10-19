using InmoCRM.Api.Dtos;
using InmoCRM.Api.Models;

namespace InmoCRM.Api.Extensions
{
    public static class AssetExtensions
    {
        public static AssetDto AsDto(this Asset asset)
        {
            return new AssetDto(
                asset.Id,
                asset.Reference,
                asset.Description,
                asset.Price,
                asset.CreatedAt
            );
        }
    }
}
