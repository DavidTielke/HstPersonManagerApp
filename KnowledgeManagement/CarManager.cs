using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.KnowledgeManagement;

public class CarManager : ICarManager
{
    private readonly ICarRepository _carRepository;

    public CarManager(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public IQueryable<Car> GetAllMercedesCars()
    {
        return _carRepository
            .Query()
            .Where(c => string.Equals(c.Brand, "Mercedes", StringComparison.OrdinalIgnoreCase) ||
                        c.Brand.StartsWith("Mercedes", StringComparison.OrdinalIgnoreCase));
    }

    public IQueryable<Car> GetAllBMWCars()
    {
        return _carRepository
            .Query()
            .Where(c => string.Equals(c.Brand, "BMW", StringComparison.OrdinalIgnoreCase) ||
                        c.Brand.StartsWith("BMW", StringComparison.OrdinalIgnoreCase));
    }
}
