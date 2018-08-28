using System;

namespace interfaces
{
  public class Helicopter : IVehicle, IAir
  {
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 6;
    public bool Winged { get; set; } = false;
    public double EngineVolume { get; set; } = 21.1;
    public double MaxAirSpeed { get; set; } = 200.7;

    public void Fly()
    {
      Console.WriteLine("The helicopter maneuvers through the air like an extremely aggressive hummingbird");
    }

  }
}