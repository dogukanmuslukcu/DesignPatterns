

// Stock Control => Payment Control => Invoice Control => Shipping Control

public class StockControl : IOrderHandler
{
    private IOrderHandler _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        var isStockAvailable = true; // Check via Stock Service

        if (_next is not null && isStockAvailable )
        {
            Console.WriteLine("Stock Controlled");
            return _next.Handle(order);
        }
        return false;

    }
}
