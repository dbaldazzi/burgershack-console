
using burgershack2.Interfaces;

namespace burgershack2.Models
{
  public abstract class FoodItem : IConsumables
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double BasePrice { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }

    public virtual string GetTemplate()
    {
      return "";
    }

    public FoodItem(string name, string description, double baseprice, int calories, int fat, int protein)
    {
      Name = name;
      Description = description;
      BasePrice = baseprice;
      Calories = calories;
      Fat = fat;
      Protein = protein;
    }
  }
}