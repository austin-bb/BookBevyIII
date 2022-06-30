using System.ComponentModel.DataAnnotations;

namespace BookBevyIII.Models;

public class Favorite
{
  [Key]
  public int FavoriteId { get; set; }

  public DateTime CreatedAt { get; set; }

  public int UserId { get; set; }
  public User? Favoriter { get; set; }

  public int BookId { get; set; }
  public Book? Book { get; set; }

  
}