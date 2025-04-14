namespace JewelryStore.Jewelry.Ring;

public class Ring : Jewelry
{
    public string RingSize { get; set; } // Размер кольца

    public Ring(string name, double price, string ringSize) : base(name, price)
    {
        RingSize = ringSize;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Размер кольца: {RingSize}");
    }
}