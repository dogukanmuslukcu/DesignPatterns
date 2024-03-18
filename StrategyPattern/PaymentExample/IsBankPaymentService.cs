using StrategyPattern.PaymentExample;

public class IsBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("İş Bankası ile ödeme yapıldı");
        return true;
    }
}

