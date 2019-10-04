namespace burgershack2.Models
{
    public class Sides
    {
        public override string GetTemplate()
        {
            return $@"
            Name: {Name}
            Description: {Description}
            Price: {Price}
            
            Any key to return to Menu";
        }

        public Sides(string name, string Description, double Price): base(sname, description, price)
    }
}