using Microsoft.AspNetCore.Mvc;

namespace HangmanGame.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}