using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager
{
    private readonly PersonRepository _personRepository;

    public PersonManager()
    {
        _personRepository = new PersonRepository();
    }

    public Person Copy(Person person)
    {
        return person;
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _personRepository
            .Query()
            .Where(p => p.Age >= 18);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _personRepository
            .Query()
            .Where(p => p.Age < 18);
    }
}