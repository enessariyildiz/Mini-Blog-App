using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "EmailAdress")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Must be max 10 characters", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string? Password { get; set; }

    }
}