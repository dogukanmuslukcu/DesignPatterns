

// Stock Control => Payment Control => Invoice Control => Shipping Control

public class ShippingControl : IOrderHandler
{
    private IOrderHandler _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        var isShippingAvailable = true; // Check via Shipping Service

        if (_next is not null && isShippingAvailable)
        {
            Console.WriteLine("Shipping Controlled");
            return _next.Handle(order);
        }
        return false;

    }
}
