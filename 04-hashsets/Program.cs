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
						Console.Write("These are the new cars in your showroom:");
						foreach (string model in Showroom)
						{
							Console.Write($" {model}");
						}
						Console.WriteLine();

						HashSet<string> UsedLot = new HashSet<string>();
						UsedLot.Add("Civic");
						UsedLot.Add("Taurus");
						UsedLot.Add("Camry");
						Console.WriteLine($"You have {UsedLot.Count} used cars on the lot");
						Console.Write("These are the used cars on your lot:");
						foreach (string car in UsedLot)
						{
							Console.Write($" {car}");
						}
						Console.WriteLine();

						Showroom.UnionWith(UsedLot);
						Console.Write("These are all the cars you have:");
						Showroom.Remove("Safari");
						foreach (string car in Showroom)
						{
							Console.Write($" {car}");
						}

        }
    }
}
