namespace burgershack2.Interfaces
{
    public interface IPurchasable
    {
         double BasePrice { get; set; }

        string GetTemplate();

    }
}