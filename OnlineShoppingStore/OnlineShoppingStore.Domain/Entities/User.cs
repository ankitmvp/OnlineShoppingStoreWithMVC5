using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.Domain.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
