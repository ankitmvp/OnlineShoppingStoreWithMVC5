using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
    }
}