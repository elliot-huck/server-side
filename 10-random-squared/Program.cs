using System;
using System.Linq;
using System.Collections.Generic;

namespace _10_random_squared
{
  class Program
  {

    public static void Display(List<int> list)
    {
      string listString = string.Join(", ", list);
      Console.WriteLine(listString);
			Console.WriteLine();
    }
    static void Main(string[] args)
    {
      Random Rand = new Random();

      List<int> randomNums = new List<int>();

      for (int i = 0; i < 20; i++)
      {
        randomNums.Add(Rand.Next(1, 51));
      }

      List<int> randomSquares =
      (
        from number in randomNums
        select number * number
      ).ToList();

      List<int> evenSquares =
      (
        from square in randomSquares
        where square % 2 == 0
        select square
      ).ToList();

      Console.WriteLine();
      Console.Write("All numbers: ");
      Program.Display(randomNums);
			Console.Write("All squares: ");
			Program.Display(randomSquares);
			Console.Write("Even squares: ");
			Program.Display(evenSquares);


    }
  }
}
