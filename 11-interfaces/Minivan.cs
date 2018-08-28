using System;

namespace interfaces
{
  public class Minivan : IVehicle, ILand
  {
    public int Doors { get; set; } = 5;
    public int PassengerCapacity { get; set; } = 7;
    public double EngineVolume { get; set; } = 25.0;
    public int Wheels { get; set; } = 4;
    public string TransmissionType { get; set; } = "Automatic";
    public double MaxLandSpeed { get; set; } = 84.3;

    public void Drive()
    {
      Console.WriteLine("The minivan moseys its way down the road");
    }
  }
}