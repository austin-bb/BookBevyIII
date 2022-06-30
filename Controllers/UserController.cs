using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBevyIII.Models;
using Microsoft.AspNetCore.Identity;

namespace BookBevyIII.Controllers;

public class UsersController : Controller
{
  private BookBevyContext _context;

  private int? uid
  {
    get
    {
      return HttpContext.Session.GetInt32("UserId");
    }
  }

  private bool loggedIn
  {
    get
    {
      return uid != null;
    }
  }

  public UsersController(BookBevyContext context)
  {
    _context = context;
  }
  [HttpGet("/")]
  public IActionResult LoginAndRegister()
  {
    return View("_Register");
  }

  [HttpPost("users/register")]
  public IActionResult Register(User newUser)
  {
    if (ModelState.IsValid == false)
    {
      return LoginAndRegister();
    }
    if (_context.Users.Any(User => User.Email == newUser.Email))
    {
      ModelState.AddModelError("Email", "is already in use");
      return LoginAndRegister();
    }
        if (_context.Users.Any(User => User.Username == newUser.Username))
    {
      ModelState.AddModelError("Username", "is already in use");
      return LoginAndRegister();
    }
    PasswordHasher<User> hashedPW = new PasswordHasher<User>();
    newUser.Password = hashedPW.HashPassword(newUser, newUser.Password);
    
    _context.Users.Add(newUser);
    _context.SaveChanges();

    HttpContext.Session.SetInt32("UserId", newUser.UserId);
    return View("Book", "Home");
    
  }
  
}