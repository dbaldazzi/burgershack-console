using burgershack2.Interfaces;


namespace burgershack2.Models
{
  public abstract class Drinks : IPurchasable
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double BasePrice { get; set; }
    public int Calories { get; set; }



    public double getPrice(Size size)
    {
      return BasePrice * (int)size;
    }
    public string GetTemplate()
    {
      return $@"
           Name: {Name}
           Description: {Description}
           Price: {BasePrice}
           
           Any key to return to Menu";
    }
    public Drinks(string name, string description, double basePrice, int calories)
    {
      Name = name;
      Description = description;
      BasePrice = basePrice;
      Calories = calories;
    }
  }
}
