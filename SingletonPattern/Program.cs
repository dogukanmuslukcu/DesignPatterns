using SingletonPattern;
// BEFORE SINGLETON

/* 
Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");

var countryProvider = new CountryProvider();
var countries = await countryProvider.GetCountries();
foreach (var country in countries) 
{
    Console.WriteLine(country.Name);
}
Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
var countries2 = await countryProvider.GetCountries();
foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}
Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
*/

Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");

var countries = await CountryProvider.Instance.GetCountries();
foreach (var country in countries)
{
    Console.WriteLine(country.Name);
}
Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");

var countries2 = await CountryProvider.Instance.GetCountries();
foreach (var country in countries2)
{
    Console.WriteLine(country.Name);
}
Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}");
