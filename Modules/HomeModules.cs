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
    }
  }
}
