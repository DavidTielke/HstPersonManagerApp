using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new FileReader();
            var parser = new PersonParser();
            var repo = new PersonRepository(reader, parser);
            var manager = new PersonManager(repo);
            var displayCommands = new PersonDisplayCommands(manager);


            displayCommands.DisplayAllAdults();
            displayCommands.DisplayAllChildren();
        }
    }
}
