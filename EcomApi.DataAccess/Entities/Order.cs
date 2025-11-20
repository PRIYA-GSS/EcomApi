using System.Collections;
namespace EcomApi.DataAccess.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal? Amount { get; set; }
        public int? OrderedBy { get; set; }
        public User? User { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
