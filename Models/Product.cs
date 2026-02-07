using System;
using System.ComponentModel.DataAnnotations;

namespace CatalogoVirtual.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        public string? ImagePath { get; set; }

    }
}
