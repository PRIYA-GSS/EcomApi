namespace EcomApi.DataAccess.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();

    }
}
