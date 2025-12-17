using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using DavidTielke.PMA.Logic.KnowledgeManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.Infrastructure.DiMappings
{
    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonParser, PersonParser>();
            services.AddTransient<IFileReader, FileReader>();

            // Book services
            services.AddTransient<IBookManager, BookManager>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IBookParser, BookParser>();
        }
    }
}
