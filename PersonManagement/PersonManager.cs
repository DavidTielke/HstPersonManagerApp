using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonCalculator
{

}

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _personRepository;
    private readonly PersonCalculator _calc;

    public PersonManager(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
        var repo = new PersonRepository(null, null);
    }

    public void Copy(Person person){}

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