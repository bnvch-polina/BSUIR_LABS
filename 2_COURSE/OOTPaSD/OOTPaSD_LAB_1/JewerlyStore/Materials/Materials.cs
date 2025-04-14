namespace JewelryStore.Materials;

public class Materials : JewelryUnit
{
    public string Type { get; set; } // Тип материала (например, золото, серебро)
    public double Purity { get; set; } // Чистота материала (%)

    public Materials(string name, double price, string type, double purity) : base(name, price)
    {
        Type = type;
        Purity = purity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Материал: {Name}, Тип: {Type}, Чистота: {Purity}%, Цена: {Price:C}");
    }
}