namespace Shoppingspree;

public static class ConsoleCommand
{
    public static string WriteInfo(string message)
    {
        var output = "";
        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();

        }


        return output;
    }

    public static int MenuChoice()
    {
        Console.WriteLine("Velkommen til din butikk!");
        Console.WriteLine("1. Se lagerbeholdning");
        Console.WriteLine("2. Legg til produkter i lageret");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 1 || choice > 2)
        {
            Console.WriteLine("Skriv ett gyldig tall");
            MenuChoice();
        }
        return choice;
    }

    public static void PrintStock(List<InventoryItem> stock)
    {
        foreach (var item in stock)
        {
            string type = item is ElectronicItem ? "elektrisk produkt" : "klesplagg";
            Console.WriteLine($"{item.Name} er et {type}, du har {item.Quantity} stykk på lager, og det selges til {item.Price} kroner");

        }
    }

}