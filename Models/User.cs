#pragma warning disable CS8618 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookBevyIII.Models;

public class User 
{
  [Key]
  public int UserId { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(2, ErrorMessage = "must be at least 2 characters")]
  [Display(Name = "First Name")]
  public string FName { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(2, ErrorMessage = "must be at least 2 characters")]
  [Display(Name = "Last Name")]
  public string LName { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(3, ErrorMessage = "must be at least 3 characters")]
  [MaxLength(15, ErrorMessage = "must be less than 16 characters")]
  public string Username { get; set; }

  [Required(ErrorMessage = "is required")]
  [EmailAddress]
  public string Email { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(8, ErrorMessage = "must be at least 8")]
  [DataType(DataType.Password)]
  public string Password { get; set; }

  [NotMapped]
  [Required(ErrorMessage = "is required")]
  [DataType(DataType.Password)]
  [Compare("Password", ErrorMessage = "does not match password")]
  [Display(Name = "Confirm Password")]
  public string ConfirmPassword { get; set; }

  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;

  public List<Book> PostedBooks { get; set; } = new List<Book>();

  public List<Favorite> FavoritedBooks { get; set; } = new List<Favorite>();
}