namespace JewelryStore.Jewelry;

public class Jewelry : JewelryUnit
{
    
    public List<Materials.Materials> MaterialsList { get; set; }
    public List<PreciousStones.PreciousStones> StonesList { get; set; }

    public Jewelry(string name, double price) : base(name, price)
    {
        MaterialsList = new List<Materials.Materials>();
        StonesList = new List<PreciousStones.PreciousStones>();
    }

    public void AddMaterial(Materials.Materials material)
    {
        MaterialsList.Add(material);
    }

    public void AddStone(PreciousStones.PreciousStones stone)
    {
        StonesList.Add(stone);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        Console.WriteLine("Материалы:");
        foreach (var material in MaterialsList)
        {
            material.DisplayInfo();
        }

        Console.WriteLine("Драгоценные камни:");
        foreach (var stone in StonesList)
        {
            stone.DisplayInfo();
        }
    }
}