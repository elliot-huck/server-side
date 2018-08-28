namespace interfaces
{
  public interface ILand
  {
    int Wheels { get; set; }
    string TransmissionType { get; set; }

    double MaxLandSpeed { get; set; }
    void Drive();

  }
}