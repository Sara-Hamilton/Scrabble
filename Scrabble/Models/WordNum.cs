using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WordNums.Models
{
  public class WordNum
  {
    private static Dictionary<string, string> _lower = new Dictionary<string, string>(){ {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6","six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"}, {"10", "ten"}, {"11","eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19","nineteen"} };

    private static Dictionary<string, string> _deca = new Dictionary <string, string>(){ {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "nintey"} };

    public string WriteUnderTwenty(string UserNumber)
    {
      return _lower[UserNumber];
    }

    public string WriteTwentyToHundred(string UserNumber)
    {
      string OutputString = "";
      if(Int32.Parse(UserNumber) < 20)
      {
        OutputString = WriteUnderTwenty(UserNumber);
      }
      else
      {
        char Tens = UserNumber[0];
        char Ones = UserNumber[1];
        OutputString = _deca[Tens.ToString()] +"-"+ _lower[Ones.ToString()];
      }
      return OutputString;
    }

    public string WriteHundredToThousand(string UserNumber)
    {
      // string lastTwoDigits = "";
      // string OutputString = "";
      // if(Int32.Parse(UserNumber.Substring(1)) < 20)
      // {
      //   lastTwoDigits = WriteUnderTwenty(UserNumber);
      // }
      // else
      // {
      //   lastTwoDigits = WriteTwentyToHundred(UserNumber.Substring(1));
      // }
      // if(UserNumber.Length >= 3)
      // {
      //   char Hundreds = UserNumber[0];
      //   OutputString = _lower[Hundreds.ToString()] + " hundred and " + lastTwoDigits;
      // }
      // else
      // {
      //   OutputString = lastTwoDigits;
      // }

      string lastTwoDigits = "";
      string OutputString = "";
      if(Int32.Parse(UserNumber) < 99)
      {
        OutputString = WriteTwentyToHundred(UserNumber);
      }
      else
      {
        char Hundreds = UserNumber[0];
        lastTwoDigits = WriteTwentyToHundred(UserNumber.Substring(1));
        OutputString = _lower[Hundreds.ToString()] + " hundred and " + lastTwoDigits;
      }
      return OutputString;
    }

    public string WriteThousandToMillion(string UserNumber)
    {
      int sub = UserNumber.Length -3;
      string xxxx = UserNumber.Substring(0,sub);
      string yyy = UserNumber.Substring(UserNumber.Length-3);
      System.Console.WriteLine("xxxx = " + xxxx);
      System.Console.WriteLine("yyy = " + yyy);
      string OutputString = WriteHundredToThousand(xxxx) + " thousand " + WriteHundredToThousand(yyy);
      return OutputString;
    }
  }

}
