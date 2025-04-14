namespace JewelryStore.Jewelry.Earrings;

public class Earrings : Jewelry
{
    public string ClaspType { get; set; } // Тип застёжки

    public Earrings(string name, double price, string claspType) : base(name, price)
    {
        ClaspType = claspType;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип застёжки: {ClaspType}");
    }
}