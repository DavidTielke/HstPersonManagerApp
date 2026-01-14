using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public class CarParser : ICarParser
{
    public Car Parse(string dataLine)
    {
        var parts = dataLine.Split(',');
        return new Car
        {
            Id = int.Parse(parts[0]),
            Brand = parts.Length > 1 ? parts[1] : string.Empty,
            Model = parts.Length > 2 ? parts[2] : string.Empty,
            Year = parts.Length > 3 ? int.Parse(parts[3]) : 0
        };
    }
}
