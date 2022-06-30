using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBevyIII.Models;

namespace BookBevyIII.Controllers;

public class BooksController : Controller
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

    public BooksController(BookBevyContext context)
    {
      _context = context;
    }

<<<<<<< HEAD
    // [HttpGet("/Books/Dashboard")]
    // public IActionResult Dashboard()
    // {
      
    // }
=======
>>>>>>> 0d7966c778bb1bceb1e75e319177a22e6e7fc7e9
}