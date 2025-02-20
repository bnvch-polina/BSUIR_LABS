namespace LibrarySystem;

public class Reader : Person
{
    public int AmountOfReadBooks { get; set; }
    public Reader(string name, int age, int amountOfReadBooks) : base(name, age)
    {
        AmountOfReadBooks = amountOfReadBooks;
    }

    public void ReadBook(Book book)
    {
        Console.WriteLine($"{Name} is reading {book.Title}.");
    }
}