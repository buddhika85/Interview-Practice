using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Library App");

        var book1 = new Book { Id = 1, Title = "Famouse Five" };
        book1.Pages.Add(1, "A");
        book1.Pages.Add(2, "B");
        book1.Pages.Add(3, "C");
        var book2 = new Book { Id = 2, Title = "Secret Seven" };
        book2.Pages.Add(1, "AA");
        book2.Pages.Add(2, "BB");
        book2.Pages.Add(3, "CC");

        User user = new User { Id = 1, Name = "John" };
        user.AddBook(book1);
        user.AddBook(book2);
        user.SetActiveBook(book2);
        Console.WriteLine(user);


        var book3 = user.FindBookByTitle("Famouse Five");
        if (book3 != null)
        {
            book3.SetLastPageRead(2);
            user.SetActiveBook(book3);
        }        

        book3 = user.FindBookByTitle("Secret Seven");
        book3?.SetLastPageRead(1);
       

        Console.WriteLine($"\n{user}");

    }
}

public class BaseEntity
{
    public int Id { get; set; }
}

public class User : BaseEntity
{ 
    public required string Name { get; set; }
    public UserLibrary Library { get; } = new UserLibrary();

    public void AddBook(Book book) => Library.AddBook(book);
    public void RemoveBook(Book book) => Library.RemoveBook(book);
    public void SetActiveBook(Book book) => Library.SetActiveBook(book);
    public Book? FindBookByTitle(string title) => Library.FindBookByTitle(title);

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Name}");
        sb.AppendLine(Library.ToString());
        return sb.ToString();
    }
}

public class Book : BaseEntity
{    
    public required string Title { get; set; }    
    public int LastPageRead { get; private set; }
    public Dictionary<int, string> Pages { get; } = new Dictionary<int, string>();

    public void SetLastPageRead(int lastPage) => LastPageRead = lastPage;
    public string GetPageContent(int pageNumber)
    {
        if (Pages.TryGetValue(pageNumber, out string? pageContent))
        {
            return pageContent;
        }
        return $"No page with number {pageNumber}";
    }
    public override string ToString() => $"{Title} Last Page read: {LastPageRead} {GetPageContent(LastPageRead)}";
}

public class UserLibrary
{
    public IList<Book> Books { get; } = new List<Book>();
    public Book? ActiveBook { get; private set; }

    public void AddBook(Book book) => Books.Add(book);
    public void RemoveBook(Book book) => Books.Remove(book);
    public void SetActiveBook(Book book) => ActiveBook = book;
    public Book? FindBookByTitle(string title) => Books.SingleOrDefault(x => x.Title == title);

    public override string ToString() 
    {
        StringBuilder sb = new StringBuilder($"Library Information");
        sb.AppendLine($"Book Count: {Books.Count}");
        sb.AppendLine($"Active Book: {ActiveBook}");
        sb.AppendLine($"All Books");
        for (int i = 0; i < Books.Count; i++)
        {
            Book? book = Books[i];
            sb.AppendLine($"\t{i + 1} - { book }");
        }
        return sb.ToString();
    }
}