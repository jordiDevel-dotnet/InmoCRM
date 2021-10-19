using System;

namespace InmoCRM.Api.Dtos
{
    public record AssetDto(Guid Id, string Reference, string Description, decimal Price, DateTimeOffset CreatedAt);
}
