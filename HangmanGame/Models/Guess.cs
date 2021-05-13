using System.Collections.Generic;

namespace HangmanGame.Models
{
  public class Guess
  {
    public string Letter {get;set;}
    private static List<Guess> _instances = new List<Guess> {};
    public Guess(string userGuess)
    {
      Letter = userGuess;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Guess> GetAll()
    {
      return _instances;
    }
    public static Guess Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}




