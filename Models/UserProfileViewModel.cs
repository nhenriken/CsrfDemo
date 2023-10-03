using System.ComponentModel.DataAnnotations;

namespace CsrfDemo.Models;

public class UserProfileViewModel
{
    public string? UserId { get; set; }

    [Required]
    [Display(Name = "Username")]
    public string? UserName { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string? Email { get; set; }

    // Add other properties as needed
}
