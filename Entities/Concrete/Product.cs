using System;
using Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 100)]
        public int Stock { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }
    }
}