using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.KnowledgeManagement;

public class BookManager : IBookManager
{
    private readonly IBookRepository _bookRepository;

    public BookManager(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IQueryable<Book> GetAllEnglishBooks()
    {
        return _bookRepository
            .Query()
            .Where(b => string.Equals(b.Language, "en", StringComparison.OrdinalIgnoreCase) ||
                        b.Language.StartsWith("en", StringComparison.OrdinalIgnoreCase));
    }

    public IQueryable<Book> GetAllGermanBooks()
    {
        return _bookRepository
            .Query()
            .Where(b => string.Equals(b.Language, "de", StringComparison.OrdinalIgnoreCase) ||
                        b.Language.StartsWith("de", StringComparison.OrdinalIgnoreCase));
    }
}