// ...existing code...
using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public class BookParser : IBookParser
{
    public Book Parse(string dataLine)
    {
        var parts = dataLine.Split(',');
        return new Book
        {
            Id = int.Parse(parts[0]),
            Title = parts.Length > 1 ? parts[1] : string.Empty,
            Author = parts.Length > 2 ? parts[2] : string.Empty,
            Language = parts.Length > 3 ? parts[3] : string.Empty
        };
    }
}
// ...existing code...