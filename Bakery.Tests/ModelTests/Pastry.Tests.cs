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

    public void GetPastryCount_ReturnsCountOfPastries ()
    {
      Pastry newPastry = new Pastry(2);
      int testCount = 1;
      Assert.AreEqual(testCount, newPastry.PastryCount);
    }
  }
}