using System.ComponentModel.DataAnnotations;

namespace EcomApi.Models.DTOs
{
    public class Product
    {
        public int? ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? ProductName { get; set; }
        [Required]
        public decimal? Price { get; set; }
      
        public int? OrderId { get; set; }
    }
}
