namespace JewelryStore.Jewelry.Watches;

public class Watches : Jewelry
{
    public string MechanismType { get; set; } // Тип механизма (например, кварцевый)

    public Watches(string name, double price, string mechanismType) : base(name, price)
    {
        MechanismType = mechanismType;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип механизма: {MechanismType}");
    }
}