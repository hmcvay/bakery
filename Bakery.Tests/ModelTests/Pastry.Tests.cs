using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesNewPastry_Pastry()
    {
      Pastry newPastry = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]

    public void GetPastryCount_ReturnsCountOfPastries_Int ()
    {
      Pastry newPastry = new Pastry(2);
      int testCount = 2;
      Assert.AreEqual(testCount, newPastry.PastryCount);
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPriceOfPastries_Int()
    {
      Pastry newPastry = new Pastry(4);
      int units = newPastry.PastryCount;
      int price = Pastry.GetPastryPrice(units);
      Assert.AreEqual(7, price);
    }
  }
}