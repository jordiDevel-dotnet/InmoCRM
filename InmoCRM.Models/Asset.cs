using InmoCRM.Models.Crud;
using System;

namespace InmoCRM.Models
{
    public class Asset : IEntity
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
