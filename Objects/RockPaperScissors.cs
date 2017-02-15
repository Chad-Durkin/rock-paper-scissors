using System.Collections.Generic;
using System;

namespace RockPaperScissorsApp.Objects
{
  public class Game
  {
    private int _player1;
    private int _player2;
    private string _results;
    private static List<int> _moves = new List<int>();

    public Game(int player1, int player2)
    {
      if(player2 == 4)
      {
        _player1 = player1;
        Random roll = new Random();
        _player2 = roll.Next(1, 4);
        _moves.Add(_player1);
        _moves.Add(_player2);
      }
      else {
        _player1 = player1;
        _player2 = player2;
        _moves.Add(_player1);
        _moves.Add(_player2);
      }
    }

    public void PlayGame()
    {
      if(_player1 == _player2)
      {
        _results = "draw";
      }
      else if(_player1 == 1 && _player2 == 3)
      {
        _results = "player 1 wins";
      }
      else if(_player2 == 1 && _player1 == 3)
      {
        _results = "player 2 wins";
      }
      else
      {
        if(_player1 < _player2)
        {
          _results = "player 2 wins";
        }
        else
        {
          _results = "player 1 wins";
        }
      }
    }

    public static List<int> GetMoves()
    {
      return _moves;
    }

    public string GetResult()
    {
      return _results;
    }

    public static void DeleteAll()
    {
      _moves.Clear();
    }

  }
}
