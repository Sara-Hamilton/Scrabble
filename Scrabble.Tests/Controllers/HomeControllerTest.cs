using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Scrabble.Controllers;
using Scrabble.Models;

namespace Scrabble.Tests
{
  // [TestClass]
  // public class HomeControllerTest
  // {
  //   [TestMethod]
  //   public void Index_ReturnCorrectView_Red()
  //   {
  //     //arrange
  //     HomeController controller = new HomeController();
  //
  //     //act
  //     IActionResult indexView = controller.Index();
  //     ViewResult result = indexView as ViewResult;
  //
  //     //assert
  //     Assert.IsInstanceOfType(result, typeof(string));
  //   }
  //
  //   [TestMethod]
  //   public void Index_ReturnCorrectView_Green()
  //   {
  //     //arrange
  //     HomeController controller = new HomeController();
  //
  //     //act
  //     IActionResult indexView = controller.Index();
  //     ViewResult result = indexView as ViewResult;
  //
  //     //assert
  //     Assert.IsInstanceOfType(result, typeof(ViewResult));
  //   }
  //
  //
  //   [TestMethod]
  //   public void Index_HasCorrectModelType_Red()
  //   {
  //     //arrange
  //     ViewResult IndexView = new HomeController().Index() as ViewResult;
  //     //act
  //     var result = IndexView.ViewData.Model;
  //     System.Console.WriteLine("result: "+result);
  //
  //     //assert
  //     Assert.IsInstanceOfType(result, typeof(string));
  //   }
  //
  //   [TestMethod]
  //   public void Index_HasCorrectModelType_Green()
  //   {
  //     //arrange
  //     ViewResult IndexView = new HomeController().Index() as ViewResult;
  //     //act
  //     var result = IndexView.ViewData.Model;
  //     System.Console.WriteLine("result: "+result);
  //
  //     //assert
  //     Assert.IsInstanceOfType(result, typeof(ScrabbleWord));
  //   }
  // }

}
