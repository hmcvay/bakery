using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesNewBread_Bread()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]

    public void UnitCount_ReturnBreadUnitCount_Int()
    {
      Bread newBread = new Bread(2);
      int units = newBread.UnitCount;
      Assert.AreEqual(3, units);
    }

  }
}