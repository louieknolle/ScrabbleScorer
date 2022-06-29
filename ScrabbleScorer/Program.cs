using System;
using System.Collections.Generic;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  public class Program
  {
   public static void Main() 
   {
    Console.WriteLine("Welcome to the premier Scrabble score checker!");
    Console.WriteLine("Please enter a word to see the Scrabble value!");
    string userInput = Console.ReadLine();
    ScrabbleWord newWord = new ScrabbleWord(userInput);

    int wordScore = newWord.FindWordScore();
    Console.WriteLine("That word is worth " + wordScore + " points!");

    Main();
  }
  
}
}