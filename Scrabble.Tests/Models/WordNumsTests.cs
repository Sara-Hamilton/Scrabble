using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordNums.Models;

namespace WordNums.Tests
{
  [TestClass]
  public class WordNumTest
  {
    [TestMethod]
    public void WriteUnderTwenty_OutputMatch_Green()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteUnderTwenty("12");
      //assert
      Assert.AreEqual("twelve", resultWord);
    }

    [TestMethod]
    public void WriteUnderTwenty_OutputMatch_Red()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteUnderTwenty("12");
      //assert
      Assert.AreEqual("twelv", resultWord);
    }

    [TestMethod]
    public void WriteTwentyToHundred_OutputMatch_Green()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteTwentyToHundred("22");
      //assert
      Assert.AreEqual("twenty-two", resultWord);
    }

    [TestMethod]
    public void WriteHundredToThousand_OutputMatch_Green()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteHundredToThousand("222");
      //assert
      Assert.AreEqual("two hundred and twenty-two", resultWord);
    }


    [TestMethod]
    public void WriteThousandToMillion_OutputMatch_Green()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteThousandToMillion("25919");
      //assert
      Assert.AreEqual("twenty-five thousand nine hundred and nineteen", resultWord);
    }
    [TestMethod]
    public void WriteThousandToMillion_OutputMatchUnderTwenty_Green()
    {
      //arrange
      WordNum newWordNum = new WordNum();
      //action
      string resultWord = newWordNum.WriteThousandToMillion("15919");
      //assert
      Assert.AreEqual("fifteen thousand nine hundred and nineteen", resultWord);
    }


  }
}
