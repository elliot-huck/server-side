using System;
using System.Linq;
using System.Collections.Generic;


namespace interfaces
{
  public class Program
  {

    public static void Main()
    {
      List<IVehicle> allVehicles = new List<IVehicle>()
      {
        new JetSki(),
        new Minivan(),
        new Motorcycle(),
        new Pickup(),
        new Submarine(),
      };

      // Build a collection of all vehicles that fly
			List<IAir> airVehicles = new List<IAir>()
			{
				new Cessna(),
				new Helicopter(),
				new Seaplane(),
			};
      // With a single `foreach`, have each vehicle Fly()
			Console.WriteLine("Flying vehicles:");
			foreach (IAir vehicle in airVehicles)
			{
					vehicle.Fly();
			}
			Console.WriteLine();


      // Build a collection of all vehicles that operate on roads
			List<ILand> landVehicles = new List<ILand>()
			{
				new Minivan(),
				new Motorcycle(),
				new Pickup(),
			};

      // With a single `foreach`, have each road vehicle Drive()
			Console.WriteLine("Road vehicles:");
			foreach (ILand vehicle in landVehicles)
			{
					vehicle.Drive();
			}
			Console.WriteLine();


      // Build a collection of all vehicles that operate on water
			List<IWater> waterVehicles = new List<IWater>()
			{
				new JetSki(),
				new Seaplane(),
				new Submarine(),
			};

      // With a single `foreach`, have each water vehicle Drive()
			Console.WriteLine("Marine vehicles:");
			foreach (IWater vehicle in waterVehicles)
			{
					vehicle.Drive();
			}
    }

  }
}