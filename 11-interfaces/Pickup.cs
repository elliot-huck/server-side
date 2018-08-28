using System;

namespace interfaces
{
  public class Pickup : IVehicle, ILand
  {
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 5;
    public double EngineVolume { get; set; } = 28.0;
    public int Wheels { get; set; } = 6;
    public string TransmissionType { get; set; } = "Automatic";
    public double MaxLandSpeed { get; set; } = 90.2;

    public void Drive()
    {
      Console.WriteLine("The pickup rumbles along the dirt road, country music blaring from its radio speakers");
    }
  }
}