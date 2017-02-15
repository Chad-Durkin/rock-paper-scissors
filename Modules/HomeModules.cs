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
        Dictionary<string, string> model = new Dictionary<string, string>{};
        model.Add("player1", newGame.GetPlayer1());
        model.Add("player2", newGame.GetPlayer2());
        model.Add("results", newGame.GetResult());
        model.Add("player1 wins", Game.GetPlayer1Wins());
        model.Add("player2 wins", Game.GetPlayer2Wins());
        model.Add("player1 losses", Game.GetPlayer1Losses());
        model.Add("player2 losses", Game.GetPlayer2Losses());

        return View["results.cshtml", model];
      };
    }
  }
}
