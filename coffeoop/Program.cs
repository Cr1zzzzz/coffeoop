using System;

class Coffee
{
    public string Name { get; }
    public double Price { get; }

    public Coffee(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return Name;
    }
}

class CoffeeMachine
{
    public static void Main()
    {
        Coffee espresso = new Coffee("Еспресо", 1.5);
        Coffee americano = new Coffee("Американо", 2);
        Coffee latte = new Coffee("Латте", 3);

        Console.WriteLine("Варіанти кави:");
        Console.WriteLine("1. " + espresso);
        Console.WriteLine("2. " + americano);
        Console.WriteLine("3. " + latte);

        Console.Write("Оберіть варіант кави (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        Coffee selectedCoffee = null;
        switch (choice)
        {
            case 1:
                selectedCoffee = espresso;
                break;
            case 2:
                selectedCoffee = americano;
                break;
            case 3:
                selectedCoffee = latte;
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                return;
        }

        Console.Write("Чи бажаєте додати сироп? (Так/Ні): ");
        string addSyrup = Console.ReadLine();
        if (addSyrup.ToLower() == "так")
        {
            Console.WriteLine("Сироп було додано.");
        }

        Console.Write("Скільки цукру додати (ліжок): ");
        int sugar = int.Parse(Console.ReadLine());
        Console.WriteLine($"Додано {sugar} ліжок цукру.");

        double totalPrice = selectedCoffee.Price;
        if (addSyrup.ToLower() == "так")
        {
            totalPrice += 0.5;
        }
        totalPrice += 0.1 * sugar;

        Console.WriteLine($"Ви обрали: {selectedCoffee}");
        Console.WriteLine("Приготування кави...");
        Console.WriteLine($"Ціна напою: {totalPrice}$");
    }
}
