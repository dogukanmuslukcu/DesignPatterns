var samsung = new Product("Samsung s28", 1000);
var apple = new Product("İphone 11", 1000);
var observer = new Observer("Doğukan Muslukçu");
var amazon = new Amazon();
amazon.Register(observer, samsung);
amazon.NotifyForProductName("Samsung s28");

Console.ReadLine();
