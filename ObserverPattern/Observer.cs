
public class Observer : IObserver
{
    public string FullName { get; set; }

    public Observer(string fullName)
    {
        FullName = fullName;
    }

    public void StockUpdate(Product product) 
    {
        Console.WriteLine($"{FullName},Product {product.Name} in stock now!");
    }
}
