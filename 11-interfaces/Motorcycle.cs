using System;

namespace interfaces
{
    public class Motorcycle : IVehicle, ILand
  {
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
      Console.WriteLine("The motorcycle screams down the highway");
    }

  }
}