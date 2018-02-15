using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;
using System;
using System.Text.RegularExpressions;

namespace Scrabble.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ScrabbleWord newScrabbleWord = new ScrabbleWord("");
        return View(newScrabbleWord);

      }
      [HttpPost("/")]
      public ActionResult Result()
      {
        string userWord = Request.Form["userWord"];
        ScrabbleWord newScrabbleWord = new ScrabbleWord(userWord);
        return View("Index", newScrabbleWord);
      }

    }
}
