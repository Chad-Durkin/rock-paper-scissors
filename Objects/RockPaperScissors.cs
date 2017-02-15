using System.Collections.Generic;
using System;

namespace RockPaperScissorsApp.Objects
{
  public class Game
  {
    private int _player1;
    private int _player2;
    private string _results;
    private static int _player1wins = 0;
    private static int _player2wins = 0;
    private static int _player1losses = 0;
    private static int _player2losses = 0;

    private static List<int> _moves = new List<int>();
    private static List<int> _plays = new List<int>(){1, 2, 3};
    private static bool _computer = false;

    public Game(int player1, int player2)
    {
      if(player2 == 4)
      {
        _computer = true;
        _player1 = player1;
        Random probabilityRoll = new Random();
        int testRollForProb = probabilityRoll.Next(0,11);
        if(testRollForProb > 5)
        {
          //pick from highest win rate
          Random roll = new Random();
          int indexOfPlays = roll.Next(0, _plays.Count);
          _player2 = _plays[indexOfPlays];
          Console.WriteLine("You've made it and the roll is: " + _player2);
          for(int index = 0; index < _plays.Count; index++) {
            Console.WriteLine(_plays[index]);
          }
        }
        else
        {
          Random roll = new Random();
          _player2 = roll.Next(1, 4);
          _moves.Add(_player1);
          _moves.Add(_player2);
        }
      }
      else {
        _computer = false;
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
        _player1wins++;
        _player2losses++;
        if(_computer == true)
        {
          _plays.Add(2);
        }
      }
      else if(_player2 == 1 && _player1 == 3)
      {
        _results = "player 2 wins";
        _player2wins++;
        _player1losses++;
        if(_computer == true)
        {
          _plays.Add(_player2);
        }
      }
      else
      {
        if(_player1 < _player2)
        {
          _results = "player 2 wins";
          _player2wins++;
          _player1losses++;
          if(_computer == true)
          {
            _plays.Add(_player2);
          }
        }
        else
        {
          _results = "player 1 wins";
          _player1wins++;
          _player2losses++;
          if(_computer == true)
          {
            _plays.Add(_player1);
          }
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

    public string GetPlayer1()
    {
      if(_player1 == 1)
      {
        return "rock";
      }
      else if(_player1 == 2)
      {
        return "paper";
      }
      else
      {
        return "scissors";
      }
    }

    public string GetPlayer2()
    {
      if(_player2 == 1)
      {
        return "rock";
      }
      else if(_player2 == 2)
      {
        return "paper";
      }
      else
      {
        return "scissors";
      }
    }

    public static string GetPlayer1Wins()
    {
      return _player1wins.ToString();
    }

    public static string GetPlayer2Wins()
    {
      return _player2wins.ToString();
    }

    public static string GetPlayer1Losses()
    {
      return _player1losses.ToString();
    }

    public static string GetPlayer2Losses()
    {
      return _player2losses.ToString();
    }

    public static void DeleteAll()
    {
      _moves.Clear();
    }

  }
}
