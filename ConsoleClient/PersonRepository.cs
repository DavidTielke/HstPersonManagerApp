using ConsoleClient.DataClasses;

namespace ConsoleClient;

public class PersonRepository
{
    private readonly FileReader _reader;
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _parser = new PersonParser();
        _reader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _reader.ReadAllLines("data.csv");
        var persons = dataLines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}