using System.ComponentModel.DataAnnotations;
namespace EcomApi.Models.DTOs
{
    public class Order
    {
        public int? OrderId { get; set; }
        [Required]
        public decimal? Amount { get; set; }
       
        public int? OrderedBy { get; set; }

        public IList<int>? ProductIds { get; set; } = new List<int>();
    }
}
