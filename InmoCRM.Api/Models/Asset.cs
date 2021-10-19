using System;
using System.Collections.Generic;

#nullable disable

namespace InmoCRM.Api.Models
{
    public partial class Asset
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
