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

      // char[] score1 = new char[] { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
      // char[] score2 = new char[] { 'D', 'G' };
      // char[] score3 = new char[] { 'B', 'C', 'M', 'P' };
      // char[] score4 = new char[] { 'F', 'H', 'V', 'W', 'Y' };
      // char[] score5 = new char[] { 'K' };
      // char[] score8 = new char[] { 'J', 'X' };
      // char[] score10 = new char[] { 'Q', 'Z' };


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

    public static int WordScore(string word)
    {
      int score = 0;
      return score;
    }

  }

}