namespace ConsoleClient;

public class FileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}