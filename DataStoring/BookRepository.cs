using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class BookRepository : IBookRepository
{
    private readonly IFileReader _reader;
    private readonly IBookParser _parser;

    public BookRepository(IFileReader reader, IBookParser parser)
    {
        _reader = reader;
        _parser = parser;
    }

    public IQueryable<Book> Query()
    {
        var dataLines = _reader.ReadAllLines("books.csv");
        var books = dataLines.Select(_parser.Parse);
        return books.AsQueryable();
    }
}