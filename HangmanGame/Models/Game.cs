using System.Collections.Generic;

namespace HangmanGame.Models
{
  public class Game
  {
    private static List<string> _generatedWords = new List<string> { "uncovered" };
    public char[] Word { get; set; }
    public int Id { get; }
    public Game(string word)
    {
      Word = _generatedWords[0].ToCharArray; 
    }
    
  }
}



