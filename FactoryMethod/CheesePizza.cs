public class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Cheese Pizza Baked");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese Pizza Cut");

    }

    public void Prepare()
    {
        Console.WriteLine("Cheese Pizza Prepared");
    }
}
