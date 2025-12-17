namespace DavidTielke.PMA.UI.ConsoleClient;

class App
{
    private readonly IPersonDisplayCommands _displayCommands;
    private readonly IBookDisplayCommands _bookDisplayCommands;

    public App(IPersonDisplayCommands displayCommands, IBookDisplayCommands bookDisplayCommands)
    {
        _displayCommands = displayCommands;
        _bookDisplayCommands = bookDisplayCommands;
    }

    public void Run()
    {
        _displayCommands.DisplayAllAdults();
        _displayCommands.DisplayAllChildren();

        _bookDisplayCommands.DisplayAllEnglishBooks();
        _bookDisplayCommands.DisplayAllGermanBooks();
    }
}