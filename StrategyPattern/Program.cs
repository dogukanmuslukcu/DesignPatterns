/*
var gameCharacter = new Character(new AggressiveCombatAttack());
gameCharacter.ApplyAttackStrategy();

gameCharacter.SetCombatStrategy(new DefensiveCombatAttack());

gameCharacter.ApplyAttackStrategy();
gameCharacter.ApplyAttackStrategy();
Console.ReadLine();
*/

using StrategyPattern.PaymentExample;

var paymentOption= new PaymentOptions()
{
    CardNumber = "1111222233334444",
    CardHolderName = "Doğukan Muslukçu",
    ExpirationDate = "12/29",
    Cvv = "321",
    Amount = 500
};

var paymentService = new PaymentService();
do
{
    Console.WriteLine("Ödeme yapılacak bankayı seçiniz (1: Garanti, 2: YapıKredi 3: İş Bankası) :");
    var bankChoice = Console.ReadLine();

    IPaymentService bankPaymentService = null;
    switch (bankChoice)
    {
        case "1":
            bankPaymentService = new GarantiBankPaymentService();
            break;
        case "2":
            bankPaymentService = new YapiKrediBankPaymentService();
            break;
        case "3":
            bankPaymentService = new IsBankPaymentService();
            break;
        default:
            Console.WriteLine("Geçersiz banka seçimi. Lütfen tekrar deneyin.");
            break;
    }
    paymentService.SetPaymentService(bankPaymentService);
    paymentService.PayViaStrategy(paymentOption);
} while (Console.ReadKey().Key != ConsoleKey.Escape);
