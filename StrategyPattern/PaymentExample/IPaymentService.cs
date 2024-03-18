using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.PaymentExample
{
    public interface IPaymentService
    {
        bool Pay(PaymentOptions paymentOptions);
    }
}
