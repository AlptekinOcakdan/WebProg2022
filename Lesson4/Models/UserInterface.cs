using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lesson4.Models
{
    public class UserInterface
    {
        [Required(ErrorMessage = "Alanı Doldurunuz.")]
        public string UserName { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
