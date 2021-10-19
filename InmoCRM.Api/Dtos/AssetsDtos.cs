using System;

namespace InmoCRM.Api.Dtos
{
    public record AssetDto(int Id, string Reference, string Description, decimal Price, DateTimeOffset CreatedAt);
}
