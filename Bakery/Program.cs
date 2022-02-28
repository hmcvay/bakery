using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{

  public class Program
  {
    public static void Main()
    {
      int breadAmount = 0;
      int pastryAmount = 0;
      int breadTotal = 0;
      int pastryTotal = 0;

      Console.WriteLine("----------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
      Console.WriteLine("PASTRY: $2 each, or 3 for $5");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Would you like to buy today?");
      Console.WriteLine("Type 'Y' for YES and 'N' for NO");
      Console.WriteLine("----------------------------------");
      string response = Console.ReadLine().ToLower();
      if (response == "y")
      {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("FANTASTIC!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Please choose PASTRY or BREAD");
        Console.WriteLine("----------------------------------");
        Start();
        async void Start()
        {
          string choice = Console.ReadLine().ToLower();
          if (choice == "bread")
          {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please enter how many loaves to order:");
            breadAmount += Int32.Parse(Console.ReadLine());
            Bread custBread = new Bread(breadAmount);
            breadTotal += Bread.GetUnitPrice(breadAmount);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(breadAmount + " loaves of bread = $" + breadTotal);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Would you like add more BREAD or PASTRY to your oder? or are you DONE?");
            Console.WriteLine("----------------------------------");
            Start();
          }
          else if (choice == "pastry")
          {
            Console.WriteLine("PASTRY: $2 each, or 3 for $5");
            Console.WriteLine("Please enter how many pastries to order:");
            pastryAmount += Int32.Parse(Console.ReadLine());
            Pastry custPastry = new Pastry(pastryAmount);
            pastryTotal += Pastry.GetPastryPrice(pastryAmount);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(pastryAmount + " pastries = $" + pastryTotal);
            Console.WriteLine("Would you like add more BREAD or PASTRY to your oder? or are you DONE?");
            Console.WriteLine("----------------------------------");
            Start();
          }
          else if (choice == "done")
          {
            int grandTotal = pastryTotal + breadTotal;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Your grand total is: $" + grandTotal);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Thank you");
            Console.WriteLine("Come again soon ♡´･ᴗ･`♡");
            Console.WriteLine("----------------------------------");
          }
          else
          {
            Console.WriteLine("please enter valid response. Either: BREAD, PASTRY, or DONE");
            Console.WriteLine("----------------------------------");
            Start();
          }
        }
      }
      else
      {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("You make me sad (｡•́︿•̀｡)");
        Console.WriteLine("See you another time.");
        Console.WriteLine("----------------------------------");
      }
    }
  }
}