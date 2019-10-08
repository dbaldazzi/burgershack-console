using System.Collections.Generic;
using burgershack2.Models;

namespace burgershack2.Services
{
  public class EntreeService
  {
    public List<Entree> Entrees { get; private set; }
    public List<string> Messages { get; set; }

    public void Setup()
    {
      Entree steak = new Entree("T-Bone", "prime cut grilled to your liking", 15d, 300, 12, 8);
      Entree burger = new Entree("Cheese Burger", "1/4pounder with lettace, bacon and cheese", 10, 10, 10, 10);
      Entree chicken = new Entree("Spicy Chicken Sandwich", "grilled chicken breast on bun", 12, 10, 10, 10);

      Entrees.AddRange(new Entree[] { steak, burger, chicken });
    }
    internal void GetEntree(int index)
    {
      if (index < Entrees.Count && index > -1)
      {
        Entree Entree = Entrees[index];
        Messages.Add(Entree.GetTemplate());
        if (Entree is Entree)
        {
          Entree EntreeEntree = (Entree)Entree;
        }
      }
      else
      {
        Messages.Add("invalid Choice");
      }
    }
    public void GetEntree()
    {
      Messages.Add("Available Entrees");
      for (int i = 0; i < Entrees.Count; i++)
      {
        Entree entree = Entrees[i];
        Messages.Add($"{i + 1}: {entree.Name} - {entree.BasePrice}");
      }

      Messages.Add("Type a number or q to quit");
    }
    public EntreeService()
    {
      Messages = new List<string>();
      Entrees = new List<Entree>();
    }
  }
}
