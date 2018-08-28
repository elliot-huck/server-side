namespace interfaces
{
  public interface IAir
  {
    double MaxAirSpeed { get; set; }
    int Wheels { get; set; }

    bool Winged { get; set; }
    void Fly();

  }
}