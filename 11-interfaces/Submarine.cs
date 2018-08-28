using System;

namespace interfaces
{
  public class Submarine : IVehicle, IWater
  {
    public int Doors { get; set; } = 1;
    public int PassengerCapacity { get; set; } = 40;
    public double EngineVolume { get; set; } = 50.5;
    public double MaxWaterSpeed { get; set; } = 20.2;

    public void Drive()
    {
      Console.WriteLine("The submarine ominously plows its way through the ocean's depths like a hungry shark");
    }


  }
}