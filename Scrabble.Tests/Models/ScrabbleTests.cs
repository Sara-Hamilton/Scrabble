using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleWordTest
  {
    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Red()
    {
      //arrange
      ScrabbleWord newScrabbleWord = new ScrabbleWord("word");
      newScrabbleWord.SetTotalValue(8);
      //action
      string resultWord = newScrabbleWord.GetUserWord();
      int resultNumber = newScrabbleWord.GetTotalValue();
      //assert
      Assert.AreEqual("wordd", resultWord);
      Assert.AreEqual(9, resultNumber);
    }

    [TestMethod]
    public void GetsAndSets_AllGettersAndSetters_Green()
    {
      //arrange
      ScrabbleWord newScrabbleWord = new ScrabbleWord("word");
      newScrabbleWord.SetTotalValue(8);
      //action
      string resultWord = newScrabbleWord.GetUserWord();
      int resultNumber = newScrabbleWord.GetTotalValue();
      //assert
      Assert.AreEqual("word", resultWord);
      Assert.AreEqual(8, resultNumber);
    }

    [TestMethod]
    public void GetDictionaryValue_ReturnKeyValue_Red()
    {
      //arrange
      ScrabbleWord newScrabbleWord = new ScrabbleWord("word");
      //action
      int resultNumber = newScrabbleWord.GetDictionaryValue("w");
      //assert
      Assert.AreEqual(5, resultNumber);
    }


    [TestMethod]
    public void GetDictionaryValue_ReturnKeyValue_Green()
    {
      //arrange
      ScrabbleWord newScrabbleWord = new ScrabbleWord("word");
      //action
      int resultNumber = newScrabbleWord.GetDictionaryValue("w");
      //assert
      Assert.AreEqual(4, resultNumber);
    }
  }
}
