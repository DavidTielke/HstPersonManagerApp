using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.AspNetCore.Mvc;

namespace DavidTielke.PMA.UI.ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonManager _manager;

        public PersonController(ILogger<PersonController> logger, 
            IPersonManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        [Route("/Person/Adults")]
        [HttpGet]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }

        [Route("/Person/Children")]
        [HttpGet]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
