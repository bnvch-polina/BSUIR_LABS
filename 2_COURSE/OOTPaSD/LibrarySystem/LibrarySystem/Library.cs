namespace LibrarySystem;

public class Library
{
    public List<Book> Books { get; set; }
    public List<Reader> Readers { get; set; }

    public Library()
    {
        Books = new List<Book>();
        Readers = new List<Reader>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book {book.Title} added to the library.");
    }

    public void RegisterReader(Reader reader)
    {
        Readers.Add(reader);
        Console.WriteLine($"Reader {reader.Name} registered in the library.");
    }
}