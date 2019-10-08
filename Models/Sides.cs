
using burgershack2.Interfaces;

namespace burgershack2.Models
{
  public class Side : FoodItem, IPurchasable
  {

    public override string GetTemplate()
    {
      return $@"
            Name: {Name}
            Description: {Description}
            Price: {BasePrice}
            
            Any key to return to Menu";
    }

    public Side(string name, string description, double basePrice, int cals, int fat, int protein) : base(name, description, basePrice, cals, fat, protein) { }
  }
}