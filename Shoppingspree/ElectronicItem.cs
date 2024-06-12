namespace Shoppingspree;

public class ElectronicItem : InventoryItem, ISellable
{
    public bool Battery;
    public bool Screen;

    public ElectronicItem(string name, int quantity, double price, bool battery, bool screen) : base(name, quantity,
        price)
    {
        Battery = battery;
        Screen = screen;
    }

    public double PriceCalculation(int percentage)
    {
        double priceDecrease = (Price/100) * percentage;
        double finalPrice = Price - priceDecrease;
        return finalPrice;
    }

    
}