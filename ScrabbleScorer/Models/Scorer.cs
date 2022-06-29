using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models 
{
  public class ScrabbleWord
  {

    public static Dictionary<string, int> LetterScore = new Dictionary<string, int> 
    {{"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10}};

    public string Input { get; set; }

    public ScrabbleWord(string input)
    {
      Input = input;
    }

    public int FindWordScore()
    {
      if (Input == "") 
      {
        return 0;
      }
      else 
      {
      int wordScoreCounter = 0;
      char[] userWordArray = Input.ToUpper().ToCharArray();
      for (int i = 0; i < userWordArray.Length; i++)
      {
        foreach(KeyValuePair<string, int> item in LetterScore)
        {
          if(item.Key.Contains(userWordArray[i]))
          {
            wordScoreCounter += item.Value;
          }
        }
      }
        return wordScoreCounter;
      }
    }
  }
}