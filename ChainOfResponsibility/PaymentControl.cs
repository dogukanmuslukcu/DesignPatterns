

// Stock Control => Payment Control => Invoice Control => Shipping Control

public class PaymentControl : IOrderHandler
{
    private IOrderHandler _next;

    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }
    public bool Handle(Order order)
    {
        var isPaymentAvailable = true; // Check via Payment Service

        if (_next is not null && isPaymentAvailable)
        {
            Console.WriteLine("Payment Controlled");
            return _next.Handle(order);
        }
        return false;

    }
}
