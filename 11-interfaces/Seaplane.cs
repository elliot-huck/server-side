using System;

namespace interfaces
{
  public class Seaplane : IVehicle, IAir, IWater
  {
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 8;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 21.1;
    public double MaxAirSpeed { get; set; } = 200.7;
    public double MaxWaterSpeed { get; set; } = 60.5;

    public void Drive()
    {
      Console.WriteLine("The seaplane skims across the water's surface");
    }

    public void Fly()
    {
      Console.WriteLine("The seaplane glides through the air like a flying fish");
    }

  }
}