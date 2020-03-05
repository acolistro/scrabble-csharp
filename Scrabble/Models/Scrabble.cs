using System;

namespace Letters.Models
{
  public class ScrabbleScore
  {
    public static bool ValidateString(string word)
    {
      int number;
      bool isNumber = Int32.TryParse(word, out number);

      return isNumber;
    }

    public static char[] toArray(string word)
    {
      char[] result = word.ToCharArray();
      return result;
    }

    public static int WordScore(char[] word)
    {
      int score = 0;
      foreach (var letter in word)
      {
        score += ReturnLetterScore(letter);
      }

      return score;
    }

    public static int ReturnLetterScore(char letter)
    {
      int score = 0;
      char letterUpper = char.ToUpper(letter);
      string scoreOne = "AEIOULNRST";
      string scoreTwo = "DG";
      string scoreThree = "BCMP";
      string scoreFour = "FHVWY";
      string scoreFive = "K";
      string scoreEight = "JX";
      string scoreTen = "QZ";


      if (scoreOne.Contains(letterUpper))
      {
        score = 1;
      }
      else if (scoreTwo.Contains(letterUpper))
      {
        score = 2;
      }
      else if (scoreThree.Contains(letterUpper))
      {
        score = 3;
      }
      else if (scoreFour.Contains(letterUpper))
      {
        score = 4;
      }
      else if (scoreFive.Contains(letterUpper))
      {
        score = 5;
      }
      else if (scoreEight.Contains(letterUpper))
      {
        score = 8;
      }
      else if (scoreTen.Contains(letterUpper))
      {
        score = 10;
      }
      else
      {
        throw new Exception(" Letter not in Alphabet ");
      }

      return score;
    }



  }

}