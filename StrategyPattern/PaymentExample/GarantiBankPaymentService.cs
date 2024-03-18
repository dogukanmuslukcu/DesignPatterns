using StrategyPattern.PaymentExample;

public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Garanti Bankası ile ödeme yapıldı");
        return true;
    }
}

