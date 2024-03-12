public class VeggiePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Veggie Pizza Bake");
    }

    public void Cut()
    {
        Console.WriteLine("Veggie Pizza Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Veggie Pizza Prepared");
    }
}
