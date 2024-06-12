using Shoppingspree;

//ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
//var salePrice = shirt.PriceCalculation(30);
//Console.WriteLine($"The sale price of the shirt is: {salePrice}");
//ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3400, true, true);
//salePrice = phone.PriceCalculation(40);
//Console.WriteLine($"The sale price of the phone is: {salePrice}");

InStock store = new InStock();
ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
store.AddStock(shirt);
int firstChoice = ConsoleCommand.MenuChoice();
switch (firstChoice)
{
    case 1:
        ConsoleCommand.PrintStock(store.StockList);
        break;
    case 2:
        break;
}
