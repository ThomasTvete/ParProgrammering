using System.Runtime.InteropServices;

namespace Shoppingspree;

public static class ConsoleCommand
{
    public static string GetInfo(string message)
    {
        var output = "";
        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();

        }


        return output;
    }

    public static int MenuChoice(string headline, string choice1, string choice2)
    {
        Console.WriteLine(headline);
        Console.WriteLine(choice1);
        Console.WriteLine(choice2);
        int userChoice = Convert.ToInt32(Console.ReadLine());
        if (userChoice < 1 || userChoice > 2)
        {
            Console.WriteLine("Skriv ett gyldig tall");
            MenuChoice(headline, choice1, choice2);
        }
        return userChoice;
    }

    public static void PrintStock(List<InventoryItem> stock)
    {
        foreach (ElectronicItem item in stock)
        {
            PrintElectronic(item);

        }

        foreach (ClothingItem item in stock)
        {
           PrintClothing(item); 
        }
    }

    public static void PrintElectronic(ElectronicItem item)
    {
        string screenText = item.Screen == true ? "med skjerm" : "uten skjerm";
        string batteryText = item.Battery == true ? "med batteri" : "uten battery";
        Console.WriteLine($"{item.Name} er et elektrisk produkt {screenText} og {batteryText}, du har {item.Quantity} stykk på lager, og det selges til {item.Price} kroner");
    }

    public static void PrintClothing(ClothingItem item)
    {
        Console.WriteLine($"{item.Name} er et klesplagg i størrelse {item.Size} og {item.Color} farge, du har {item.Quantity} stykk på lager, og det selges til {item.Price} kroner");
    }


    public static InventoryItem CreateItem()
    {
        int itemChoice = MenuChoice("Velg type produkt", "1. Elektronikk", "2. Klesplagg");
        string name = GetInfo("Hva heter produktet? ");
        int quantity = Convert.ToInt32(GetInfo("Antall produkter du legger til? "));
        double price = Convert.ToDouble(GetInfo("Hva skal produktet koste? "));
        switch (itemChoice)
        {
            case 1:
                bool battery = GetInfo("Har produktet batteri? ").ToLower() == "ja" ? true : false;
                bool screen = GetInfo("Har produktet en skjerm? ").ToLower() == "ja" ? true : false;
                InventoryItem item1 = new ElectronicItem(name, quantity, price, battery, screen);
                return item1;
            case 2:
                string size = GetInfo("Hvilken størrelse er plagget? ");
                string color = GetInfo("Hvilken farge er plagget? ");
                InventoryItem item2 = new ClothingItem(name, quantity, price, size, color);
                return item2;
            default:
                return null;
        }


    }


}