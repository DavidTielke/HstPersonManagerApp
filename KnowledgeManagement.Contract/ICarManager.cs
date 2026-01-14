using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Logic.KnowledgeManagement;

public interface ICarManager
{
    IQueryable<Car> GetAllMercedesCars();
    IQueryable<Car> GetAllBMWCars();
}
