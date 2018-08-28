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
				new Cessna(),
				new Helicopter(),
				new JetSki(),
				new Minivan(),
				new Motorcycle(),
				new Pickup(),
				new Seaplane(),
				new Submarine(),
			};

      // Build a collection of all vehicles that fly

      // With a single `foreach`, have each vehicle Fly()



      // Build a collection of all vehicles that operate on roads

      // With a single `foreach`, have each road vehicle Drive()



      // Build a collection of all vehicles that operate on water

      // With a single `foreach`, have each water vehicle Drive()
    }

  }
}