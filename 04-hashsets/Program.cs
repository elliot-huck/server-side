using System;
using System.Collections.Generic;

namespace hashsets
{
  class Program
  {
    static void Main(string[] args)
    {
      HashSet<string> Showroom = new HashSet<string>();
      Showroom.Add("Safari");
      Showroom.Add("Corolla");
      Showroom.Add("Camry");
      Showroom.Add("Sienna");
      Console.WriteLine($"You have {Showroom.Count} new cars in the showroom");
      Showroom.Add("Corolla");
      Console.WriteLine("These are the new cars in your showroom:");
      foreach (string model in Showroom)
      {
        Console.WriteLine($" {model}");
      }
      Console.WriteLine();

      HashSet<string> UsedLot = new HashSet<string>();
      UsedLot.Add("Civic");
      UsedLot.Add("Taurus");
      UsedLot.Add("Camry");
      Console.WriteLine($"You have {UsedLot.Count} used cars on the lot");
      Console.WriteLine("These are the used cars on your lot:");
      foreach (string car in UsedLot)
      {
        Console.WriteLine($" {car}");
      }
      Console.WriteLine();

      Showroom.UnionWith(UsedLot);
      Console.WriteLine("These are all the cars you have:");
      Showroom.Remove("Safari");
      foreach (string car in Showroom)
      {
        Console.WriteLine($" {car}");
      }
      Console.WriteLine();


      HashSet<string> Junkyard = new HashSet<string>()
      {
        "Civic",
        "Maxima",
        "Taurus",
        "Ram",
        "Pathfinder",
        "Aztec",
        "Prism",
      };

      HashSet<string> clone = new HashSet<string>(Showroom);
      clone.IntersectWith(Junkyard);
      Console.WriteLine("These are the cars from the junkyard that you have already:");
      foreach (string car in clone)
      {
        Console.WriteLine($" {car}");
      }
      Console.WriteLine();

      Showroom.UnionWith(Junkyard);
      Showroom.Remove("Aztec");
      Console.WriteLine("These are all the cars you have after purchasing from the junkyard:");
      foreach (string car in Showroom)
      {
        Console.WriteLine($" {car}");
      }
      Console.WriteLine();





    }
  }
}
