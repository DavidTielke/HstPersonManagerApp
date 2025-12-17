using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public interface IBookRepository
{
    IQueryable<Book> Query();
}