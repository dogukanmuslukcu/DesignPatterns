PizzaStore istanbulPizzaStore = new IstanbulPizzaStore();
PizzaStore ankaraPizzaStore = new AnkaraPizzaStore();

IPizza cheesePizza = ankaraPizzaStore.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in Ankara Store");

IPizza veggiePizza = istanbulPizzaStore.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in Ankara Store");


