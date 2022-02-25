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

    public void BreadPrice_ReturnBreadPrice_Int()
    {
      int breadAmount = 1;
      int breadPrice = 5;
      Bread newBread = new Bread(breadAmount);
      Assert.AreEqual(breadPrice, newBread.Price);
    }

    [TestMethod]
    
    public void ThirdFree_EveryThirdBreadFree_Int()
    {
      
    }
  }
}