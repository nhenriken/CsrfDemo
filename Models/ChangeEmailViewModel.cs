using System.ComponentModel.DataAnnotations;

namespace CsrfDemo.Models;

public class ChangeEmailViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "New Email")]
    public string? NewEmail { get; set; }
}
