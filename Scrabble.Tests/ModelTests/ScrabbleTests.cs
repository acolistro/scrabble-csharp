using Microsoft.VisualStudio.TestTools.UnitTesting;
using Letters.Models;
using System;

namespace Letters.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void ValidateString_ValidatesString_Bool()
    {
      bool word = ScrabbleScore.ValidateString("string");
      Assert.IsFalse(word, "word failed");
    }

    [TestMethod]
    public void toArray_turnsStringToCharArray_CharArray()
    {
      string word = "test";
      char[] testCharArray = new char[] { 't', 'e', 's', 't' };
      char[] result = ScrabbleScore.toArray(word);

      CollectionAssert.AreEqual(testCharArray, result);
    }

    [TestMethod]
    public void ReturnLetterScore_ReturnIntForLetterScore_Int()
    {
      char letter = 'a';
      int score = ScrabbleScore.ReturnLetterScore(letter);
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void ReturnLetterScoreThree_ReturnIntForLetterScoreOfThree_Int()
    {
      char letter = 'b';
      int score = ScrabbleScore.ReturnLetterScore(letter);
      Assert.AreEqual(3, score);
    }
    [TestMethod]
    public void ReturnLetterScoreTen_ReturnIntForLetterScoreOfTen_Int()
    {
      char letter = 'q';
      int score = ScrabbleScore.ReturnLetterScore(letter);
      Assert.AreEqual(10, score);
    }
    [TestMethod]
    public void WordScore_ReturnTotalScoreForWord_Int()
    {
      char[] word = new char[] { 't', 'e', 's', 't' };
      int score = ScrabbleScore.WordScore(word);
      Assert.AreEqual(4, score);
    }

  }
}