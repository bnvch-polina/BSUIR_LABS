namespace JewelryStore.Jewelry.Necklace;

public class Necklace : Jewelry
{
    public double Length { get; set; } // Длина ожерелья

    public Necklace(string name, double price, double length) : base(name, price)
    {
        Length = length;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Длина ожерелья: {Length} см");
    }
}