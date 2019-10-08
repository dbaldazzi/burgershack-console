namespace burgershack2.Interfaces
{
  public interface ISizes
  {
    double SizeMultiplier { get; set; }
    double GetPrice(Size s);
  }

  public enum Size
  {
    small = 1,
    medium,
    large,
    xlarge,
    murica
  }
}

