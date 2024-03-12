

// Stock Control => Payment Control => Invoice Control => Shipping Control

public class InvoiceControl : IOrderHandler
{
    private IOrderHandler _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        var isnIvoiceAvailable = true; // Check via Invoice Service

        if (_next is not null && isnIvoiceAvailable)
        {
            Console.WriteLine("İnvoice Controlled");
            return _next.Handle(order);
        }
        return false;

    }
}
