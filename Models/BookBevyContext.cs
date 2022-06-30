#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace BookBevyIII.Models;

public class BookBevyContext : DbContext
{
  public BookBevyContext(DbContextOptions options) : base(options) { }

  public DbSet<User> Users { get; set; }
  public DbSet<Book> Books { get; set; }
  public DbSet<Favorite> Favorites { get; set; }
}