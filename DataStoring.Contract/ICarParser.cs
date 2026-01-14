using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public interface ICarParser
{
    Car Parse(string dataLine);
}
