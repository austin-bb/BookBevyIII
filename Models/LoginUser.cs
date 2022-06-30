#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class LoginUser
{
  [Required(ErrorMessage = "is required")]
  [Display(Name = "Username")]
  public string LoginUsername { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(8, ErrorMessage = "must be at least 8 characters")]
  [DataType(DataType.Password)]
  [Display(Name = "Password")]
  public string LoginPassword { get; set; }
}