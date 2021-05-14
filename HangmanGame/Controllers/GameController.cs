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
    [HttpPost("/words/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Guess newGuess = Guess.Find(id);
      List<Guess> guessLetters = newGuess.Letter;
      model.Add
    }
  }
}

