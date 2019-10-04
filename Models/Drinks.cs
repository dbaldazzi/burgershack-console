namespace burgershack2.Models
{
    public class Drinks
    {
        public override string GetTemplate()
        {
           return $@"
           Name: {Name}
           Description: {Description}
           Price: {Price}
           
           Any key to return to Menu";
        }
        public Drinks(string Name, string Description, double Price): base(Name, Description, Price)
    }
}