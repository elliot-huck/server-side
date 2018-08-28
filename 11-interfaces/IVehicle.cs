namespace interfaces
{
  public interface IVehicle
  {
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
  }
}