using System.Collections.Generic;

namespace Parcels
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume{ get; set; }
    public double Cost { get; set; }

      public Parcel(int newLength, int newWidth, int newHeight, int newWeight)
      {
        Length = newLength;
        Width = newWidth;
        Height = newHeight;
        Weight = newWeight;
        GetVolumes();
        GetCostToShip();
      }

      public void GetVolumes()
      {
        Volume = Length * Width * Height;
      }

      public void GetCostToShip()
      {
        Cost = Volume * Weight / 100;
      }
  }
}
