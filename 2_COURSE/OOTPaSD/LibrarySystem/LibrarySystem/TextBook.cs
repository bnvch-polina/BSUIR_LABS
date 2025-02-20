namespace LibrarySystem;

public class Textbook : Book
{
    public string Subject { get; set; }

    public Textbook(string title, string author, int year, string subject) : base(title, author, year)
    {
        Subject = subject;
    }
}