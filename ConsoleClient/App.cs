namespace DavidTielke.PMA.UI.ConsoleClient;

class App
{
    private readonly IPersonDisplayCommands _displayCommands;
    private readonly IBookDisplayCommands _bookDisplayCommands;
    private readonly ICarDisplayCommands _carDisplayCommands;

    public App(IPersonDisplayCommands displayCommands, IBookDisplayCommands bookDisplayCommands, ICarDisplayCommands carDisplayCommands)
    {
        _displayCommands = displayCommands;
        _bookDisplayCommands = bookDisplayCommands;
        _carDisplayCommands = carDisplayCommands;
    }

    public void Run()
    {
        _displayCommands.DisplayAllAdults();
        _displayCommands.DisplayAllChildren();

        _bookDisplayCommands.DisplayAllEnglishBooks();
        _bookDisplayCommands.DisplayAllGermanBooks();

        _carDisplayCommands.DisplayAllMercedesCars();
        _carDisplayCommands.DisplayAllBMWCars();
    }
}