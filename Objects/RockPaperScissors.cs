using System.Collections.Generic;
using System;

namespace RockPaperScissorsApp.Objects
{
  public class Game
  {
    private int _player1;
    private int _player2;
    private string results;
    private static List<int> _moves = new List<int>();

    public Game(int player1, int player2)
    {
      _player1 = player1;
      _player2 = player2;
      _moves.Add(_player1);
      _moves.Add(_player2);
    }

    public void PlayGame()
    {
      if(_player1 == _player2)
      {
        _results = "draw";
      }
      else if(_player1 == 1 && player2 == 3)
      {

      }
    }

    public static List<int> GetMoves()
    {
      return _moves;
    }

  }
}
