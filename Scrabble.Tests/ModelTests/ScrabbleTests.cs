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
      Assert.IsTrue(word, "word failed");
    }

  }
}