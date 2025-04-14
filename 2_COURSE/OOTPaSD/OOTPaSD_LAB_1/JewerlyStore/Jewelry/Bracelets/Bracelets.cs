namespace JewelryStore.Jewelry.Bracelets;

public class Bracelets : Jewelry
{
    public string ClaspType { get; set; } // Тип застёжки

    public Bracelets(string name, double price, string classType) : base(name, price)
    {
        ClaspType = classType;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип застёжки: {ClaspType}");
    }
}