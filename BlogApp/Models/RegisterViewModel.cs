using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "EmailAdress")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Must be max 10 characters", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Must be max 10 characters", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Display(Name = "Password Again")]
        public string? ConfirmPassword { get; set; }

    }
}