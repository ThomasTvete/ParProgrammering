namespace Shoppingspree;

public class ClothingItem : InventoryItem, ISellable
{
    public string Size;
    public string Color;

    public ClothingItem(string name, int quantity, double price, string size, string color) : base(name, quantity, price)
    {
        Size = size;
        Color = color;
    }



    public double PriceCalculation(int percentage)
    {
        double priceDecrease = (Price / 100) * percentage;
        double finalPrice = Price - priceDecrease;
        return finalPrice;
    }
}