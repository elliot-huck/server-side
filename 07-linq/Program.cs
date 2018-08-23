using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
      Console.WriteLine("ALL FRUITS");
      foreach (string item in fruits)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      List<string> Lfruits = (from item in fruits
                              where item.StartsWith("L")
                              select item).ToList();
      Console.WriteLine("L FRUITS");
      foreach (string item in Lfruits)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();


      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };
      List<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0).ToList();
      Console.WriteLine("4 6 MULTIPLES");
      foreach (int item in fourSixMultiples)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

    }
  }
}
