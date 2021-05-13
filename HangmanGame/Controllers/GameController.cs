using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HangmanGame.Models;

namespace HangmanGame.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/words")]
    public ActionResult Index()
    {
      return View();
    }
  }
}

