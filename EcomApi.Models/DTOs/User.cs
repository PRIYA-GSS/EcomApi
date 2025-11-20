using System.ComponentModel.DataAnnotations;
namespace EcomApi.Models.DTOs
{
    public class User
    {

        public int? UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public IList<int>? OrderIds { get; set; } = new List<int>();
    }
}
