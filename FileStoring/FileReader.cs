namespace DavidTielke.PMA.Data.FileStoring;

public class FileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}