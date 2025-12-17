using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Logic.KnowledgeManagement;

public interface IBookManager
{
    IQueryable<Book> GetAllEnglishBooks();
    IQueryable<Book> GetAllGermanBooks();
}