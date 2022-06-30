#pragma warning disable CS8618 

using System.ComponentModel.DataAnnotations;

namespace BookBevyIII.Models;

public class Book
{
  [Key]
  public int BookId { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(2, ErrorMessage = "must be at least 2 characters")]
  [Display(Name = "Book Name")]
  public string BookName { get; set; }

  // Maybe create another model for author? so we can store author data 
  [Required(ErrorMessage = "is required")]
  public string BookAuthor { get; set; }
  
  [Required(ErrorMessage = "is required")]
  [MinLength(15, ErrorMessage = "must be at least 15 characters")]
  public string Description { get; set; }

  [Required(ErrorMessage = "is required")]
  public string Category { get; set; } // wasn't sure how to set this up as a list

  [Required(ErrorMessage = "is required")]
  [DataType(DataType.Date)]
  public DateTime DatePublished { get; set;}

  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;

  public List<Favorite> Favoriters { get; set; } = new List<Favorite>();
}