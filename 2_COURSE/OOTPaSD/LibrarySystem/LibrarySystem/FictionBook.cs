namespace LibrarySystem;

public class FictionBook : Book
{
    public string Genre { get; set; }

    public FictionBook(string title, string author, int year, string genre) : base(title, author, year)
    {
        Genre = genre;
    }
}