using DavidTielke.PMA.Logic.PersonManagement;
using DavidTielke.PMA.Logic.KnowledgeManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class BookDisplayCommands : IBookDisplayCommands
{
    private readonly IBookManager _manager;

    public BookDisplayCommands(IBookManager manager)
    {
        _manager = manager;
    }

    public void DisplayAllEnglishBooks()
    {
        var books = _manager.GetAllEnglishBooks().ToList();
        Console.WriteLine($"### English Books ({books.Count}) ###");
        books.ForEach(b => Console.WriteLine($"{b.Title} - {b.Author}"));
    }

    public void DisplayAllGermanBooks()
    {
        var books = _manager.GetAllGermanBooks().ToList();
        Console.WriteLine($"### Deutsche B�cher ({books.Count}) ###");
        books.ForEach(b => Console.WriteLine($"{b.Title} - {b.Author}"));
    }
}