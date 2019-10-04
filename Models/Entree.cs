namespace burgershack2.Models
{
    public class Entree
    {
        public override string GetTemplate()
        {
            return $@"
            Name: {Name}
            Description: {Description}
            Price: {Price} 

            press any key to return to menu";
        }
        public Entree(string Name, string Description, double price): base(name, description, price)
    }
}