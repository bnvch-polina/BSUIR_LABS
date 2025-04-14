namespace JewelryStore.PreciousStones;

public class PreciousStones : JewelryUnit
{
    public string Color { get; set; } // Цвет камня
    public double Carats { get; set; } // Каратность

    public PreciousStones(string name, double price, string color, double carats)
        : base(name, price)
    {
        Color = color;
        Carats = carats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Камень: {Name}, Цвет: {Color}, Каратность: {Carats}, Цена: {Price:C}");
    }
}