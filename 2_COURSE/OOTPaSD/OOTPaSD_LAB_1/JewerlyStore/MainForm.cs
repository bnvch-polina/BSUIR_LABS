using System.Text;
using JewelryStore;
using JewelryStore.Jewelry;
using JewelryStore.Jewelry.Bracelets;
using JewelryStore.Jewelry.Earrings;
using JewelryStore.Jewelry.Necklace;
using JewelryStore.Jewelry.Ring;
using JewelryStore.Materials;
using JewelryStore.PreciousStones;

namespace JewerlyStore;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        var jewelryUnit = new JewelryUnit("Золото", 99.9);
        var jewelry = new Jewelry("Кольцо с бриллиантом", 25000);
        var gold = new Materials("Золото", 99.9, "white", 3);
        var diamond = new PreciousStones("Бриллиант", 68, "Белый", 1.2);
        var bracelet = new Bracelets("Бриллиант", 68, "Белый");
        var earrings = new Earrings("SomeEarings", 8.8, "good");
        var necklace = new Necklace("SomeNecklace", 8.8, 77);
        var ring = new Ring("Gold ring", 6, "ijij");

        // Формируем строковое представление информации об объектах
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("=== JewelryUnit ===");
        sb.AppendLine($"Название: {jewelryUnit.Name}, Цена: {jewelryUnit.Price}");
        sb.AppendLine();

        sb.AppendLine("=== Jewelry ===");
        sb.AppendLine($"Название: {jewelry.Name}, Цена: {jewelry.Price}");
        sb.AppendLine();

        sb.AppendLine("=== Materials ===");
        sb.AppendLine($"Название: {gold.Name}, Цена: {gold.Price}, Тип: {gold.Type}, Чистота: {gold.Purity}");
        sb.AppendLine();

        sb.AppendLine("=== PreciousStones ===");
        sb.AppendLine(
            $"Название: {diamond.Name}, Цена: {diamond.Price}, Цвет: {diamond.Color}, Каратность: {diamond.Carats}");
        sb.AppendLine();

        sb.AppendLine("=== Bracelets ===");
        // Если у класса Bracelets есть дополнительные свойства, их также можно вывести. Здесь выводим Name, Price и третий параметр, как пример.
        sb.AppendLine(
            $"Название: {bracelet.Name}, Цена: {bracelet.Price}, Дополнительно: ");
        sb.AppendLine();

        sb.AppendLine("=== Earrings ===");
        sb.AppendLine($"Название: {earrings.Name}, Цена: {earrings.Price}, Тип застёжки: {earrings.ClaspType}");
        sb.AppendLine();

        sb.AppendLine("=== Necklace ===");
        sb.AppendLine($"Название: {necklace.Name}, Цена: {necklace.Price}, Длина: {necklace.Length}");
        sb.AppendLine();

        sb.AppendLine("=== Ring ===");
        sb.AppendLine($"Название: {ring.Name}, Цена: {ring.Price}, Размер кольца: {ring.RingSize}");
        sb.AppendLine();

        // Выводим собранную информацию на форме в элементе textBoxOutput.
        textBoxOutput.Text = sb.ToString();
    }
}