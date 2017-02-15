using System;
using System.Collections.Generic;
using Nancy;
using RockPaperScissorsApp.Objects;

namespace RockPaperScissorsApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/play"] = _ => {
        Game newGame = new Game(Request.Form["player1"], Request.Form["player2"]);
        newGame.PlayGame();
        return View["results.cshtml", newGame.GetResult()];
      };
    }
  }
}
