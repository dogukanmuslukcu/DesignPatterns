using StrategyPattern.PaymentExample;

public class YapiKrediBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Yapıkredi Bankası ile ödeme yapıldı");
        return true;
    }
}

