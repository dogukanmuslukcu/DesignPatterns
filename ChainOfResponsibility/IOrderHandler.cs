

// Stock Control => Payment Control => Invoice Control => Shipping Control

public interface IOrderHandler
{
    void SetNext(IOrderHandler next);
    bool Handle(Order order);
}
