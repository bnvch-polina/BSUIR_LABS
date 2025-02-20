namespace LibrarySystem;

public partial class MainForm : Form
{
    private Library library;
    private Librarian librarian;
    private Reader reader;
    private Textbook textbook;
    private FictionBook fictionBook;
    private ListBox listBoxInfo;
    private Button buttonShowLibrarian;
    private Button buttonShowReader;
    private Button buttonShowTextbook;
    private Button buttonShowFictionBook;
    public MainForm()
    {
        InitializeComponent();
        library = new Library();
        librarian = new Librarian("Alice", 30, 5);
        reader = new Reader("Bob", 20, 100);
        textbook = new Textbook("Mathematics", "John Doe", 1999,"Math");
        fictionBook = new FictionBook("1984", "George Orwell",1983, "Dystopian");
        library.AddBook(textbook);
        library.AddBook(fictionBook);
        library.RegisterReader(reader);
    }


    private void ButtonShowLibrarian_Click_1(object sender, EventArgs e)
    {
        MessageBox.Show($"Librarian: {librarian.Name}, Age: {librarian.Age}, Experience: {librarian.Experience}");
    }
    
    // private void ButtonShowLibrary_Click(object sender, EventArgs e)
    // {
    //     Library library = new Library();
    //     library.AddBook(new Textbook("Mathematics", "John Doe", "Math"));
    //     library.AddBook(new FictionBook("1984", "George Orwell", "Dystopian"));
    //     library.RegisterReader(new Reader("Bob", 20));
    //     MessageBox.Show($"Library has {library.Books.Count} books and {library.Readers.Count} readers.");
    // }

    private void button5_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Reader: {reader.Name}, Age: {reader.Age}, AmountOfReadBooks: {reader.AmountOfReadBooks}");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Textbook: {textbook.Title}, Author: {textbook.Author}, Subject: {textbook.Subject}");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Fiction Book: {fictionBook.Title}, Author: {fictionBook.Author}, Genre: {fictionBook.Genre}");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Librarian: {librarian.Name}, Age: {librarian.Age}, Experience: {librarian.Experience};\n" +
                        $"Reader: {reader.Name}, Age: {reader.Age}, AmountOfReadBooks: {reader.AmountOfReadBooks}");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Textbook: {textbook.Title}, Author: {textbook.Author}, Subject: {textbook.Subject}\n"+
        $"Fiction Book: {fictionBook.Title}, Author: {fictionBook.Author}, Genre: {fictionBook.Genre}");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Librarian: {librarian.Name}, Age: {librarian.Age}, Experience: {librarian.Experience};\n" +
                        $"Reader: {reader.Name}, Age: {reader.Age}, AmountOfReadBooks: {reader.AmountOfReadBooks}\n"+
        $"Textbook: {textbook.Title}, Author: {textbook.Author}, Subject: {textbook.Subject}\n"+
            $"Fiction Book: {fictionBook.Title}, Author: {fictionBook.Author}, Genre: {fictionBook.Genre}");
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}