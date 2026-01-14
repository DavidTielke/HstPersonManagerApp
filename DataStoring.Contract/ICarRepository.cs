using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public interface ICarRepository
{
    IQueryable<Car> Query();
}
