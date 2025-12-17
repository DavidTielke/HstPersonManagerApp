namespace DavidTielke.PMA.CrossCutting.DataClasses;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Language { get; set; }

    public Book() { }

    public Book(int id, string title, string author, string language)
    {
        Id = id;
        Title = title;
        Author = author;
        Language = language;
    }
}