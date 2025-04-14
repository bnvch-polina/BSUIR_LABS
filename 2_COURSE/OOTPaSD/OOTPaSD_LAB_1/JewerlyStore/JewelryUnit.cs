namespace JewelryStore;

public class JewelryUnit
{
    public string Name { get; set; } // Имя ювелирной единицы
    public double Price { get; set; } // Цена
    
    public JewelryUnit(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Цена: {Price:C}");
    }
}