namespace DavidTielke.PMA.CrossCutting.DataClasses;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {

    }

    public Person(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

// R1: Alle Komponenten folgen Namensmustern: Client, Management,
// Storing, DataClasses

// R2: Alle Namespaces einem Pattern folgen:
// - DavidTielke.PMA.Logic
// - DavidTielke.PMA.Data
// - DavidTielke.PMA.UI
// - DavidTielke.PMA.CrossCutting