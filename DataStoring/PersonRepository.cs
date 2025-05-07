using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IFileReader _reader;
    private readonly IPersonParser _parser;

    public PersonRepository(IFileReader reader, 
        IPersonParser parser)
    {
        _reader = reader;
        _parser = parser;
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _reader.ReadAllLines("data.csv");
        var persons = dataLines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}