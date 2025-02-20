namespace LibrarySystem;

public class Librarian : Person
{
    public int Experience { get; set; }
    public Librarian(string name, int age, int experience) : base(name, age)
    {
        Experience = experience;
    }
    public void ManageBooks()
    {
        Console.WriteLine($"{Name} is managing books.");
    }
}