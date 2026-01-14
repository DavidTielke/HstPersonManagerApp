using DavidTielke.PMA.Logic.KnowledgeManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

public class CarDisplayCommands : ICarDisplayCommands
{
    private readonly ICarManager _manager;

    public CarDisplayCommands(ICarManager manager)
    {
        _manager = manager;
    }

    public void DisplayAllMercedesCars()
    {
        var cars = _manager.GetAllMercedesCars().ToList();
        Console.WriteLine($"### Mercedes Cars ({cars.Count}) ###");
        cars.ForEach(c => Console.WriteLine($"{c.Brand} {c.Model} ({c.Year})"));
    }

    public void DisplayAllBMWCars()
    {
        var cars = _manager.GetAllBMWCars().ToList();
        Console.WriteLine($"### BMW Cars ({cars.Count}) ###");
        cars.ForEach(c => Console.WriteLine($"{c.Brand} {c.Model} ({c.Year})"));
    }
}
