using System; 
using System.Collections.Generic; 
using burgershack2.Models; 

namespace burgershack2.Services
{
    public class EntreeService
  {
    public List<Listing> Listings {get; private set; }
    public List<string> Messages {get; set; }

    public void Setup()
    {
          Entree Steak = new Entree("T-Bone", "prime cut grilled to your liking", 15);
          Entree Burger = new Entree("Cheese Burger", "1/4pounder with lettace, bacon and cheese", 10);
          Entree Chicken = new Entree("Spicy Chicken Sandwich", "grilled chicken breast on bun", 12); 

          Listings.AddRange(newListing[] {Steak, Burger, Chicken});
    }
    internal void GetEntree(int index) 
    {
      if(index < Listing.Count && index > -1); 
      {
        Listing listing = Listing[index];
        Messages.Add(listings.GetTemplate());
        if(listing is Entree)
        {
        Entree EntreeListing = (Entree)Listing; 
        }
      }
      else {
        Messages.Add("invalid Choice");
      }      
    }
    public void GetEntree() 
    {
      Messages.Add("Available Entrees");
      for (int i=0; i< Entree.count; i++);
      {
      Listings Entree = Listings[i]; 
      Messages.Add($"{i+1}: {Entree.name} - {Entree.Price}"); 
      }
   
    Messages.Add("Type a number or q to quit"); 
 }
 public EntreeService()
{
Messages = new List<string>();
Listings = new List<Listings>(); 
}
  }
}
