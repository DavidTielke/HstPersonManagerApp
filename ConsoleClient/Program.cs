using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Infrastructure.DiMappings;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            // UI Mappings
            serviceCollection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();
            
            // Restlichen Mappings
            new ServiceCollectionInitializer().Initialize(serviceCollection);

            var provider = serviceCollection.BuildServiceProvider();

            var displayCommands = provider.GetRequiredService<IPersonDisplayCommands>();
            
            displayCommands.DisplayAllAdults();
            displayCommands.DisplayAllChildren();
        }
    }
}
