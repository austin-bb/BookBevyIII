#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace BookBevyIII.Models;

public class BookBevyContext : DbContext
{
  public BookBevyContext(DbContextOptions options) : base(options) { }

  
}