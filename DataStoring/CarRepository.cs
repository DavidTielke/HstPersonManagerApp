using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class CarRepository : ICarRepository
{
    private readonly IFileReader _reader;
    private readonly ICarParser _parser;

    public CarRepository(IFileReader reader, ICarParser parser)
    {
        _reader = reader;
        _parser = parser;
    }

    public IQueryable<Car> Query()
    {
        var dataLines = _reader.ReadAllLines("cars.csv");
        var cars = dataLines.Select(_parser.Parse);
        return cars.AsQueryable();
    }
}
