
using burgershack2.Interfaces;


namespace burgershack2.Models
{
  public class Entree : FoodItem, IPurchasable
  {
    public Entree(string name, string description, double basePrice, int calories, int fat, int protein) : base(name, description, basePrice, calories, fat, protein)
    { }


    // public override string GetTemplate()
    // {
    //     return $@"
    //     Name: {Name}
    //     Description: {Description}
    //     Price: {Price} 

    //     "press any key to return to menu"; 
    // }
  }
}
