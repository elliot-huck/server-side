using System;

namespace interfaces
{
  public class JetSki : IVehicle, IWater
  {
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
      Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

   
  }
}