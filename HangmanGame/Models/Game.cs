using System.Collections.Generic;

namespace HangmanGame.Models
{
  public class Game
  {
    private static List<string> _generatedWords = new List<string> { "uncovered" };
    public char[] Word { get; set; }
    public int Id { get; }
    
    public Game()
    {
      Solution = _generatedWords[0];
      ValidGuesses = new List<Letter> {};
      Word = _generatedWords[0].ToCharArray; 
    }

    public List<Letter> Spread()
    {
      // syntax for a method that would spread a word into list items, each of which being letters
    }

    

    

    // Game Class
      // Solution = "uncovered";
      // Valid Guesses =
        // ['u', 'n', 'c', 'o', 'v', 'e', 'r', 'e', 'd']; (as a list)
      // another method returning a boolean value true or false checking if the guessed word matches the solution word
      // A method that passes the correct letter guess to the hangman element
      // another method that returns a static element when a guess is false/wrong
    
    // Guess class
      // User Guesses = [list of guesses]
      // foreach userguesses you compare it to the valid guesses
      // a constructor to store all of the guessed letters
      

      
  }    
}



