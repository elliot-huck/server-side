using System;

namespace interfaces
{
  public class Cessna : IVehicle, IAir
  {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
      Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

  }
}