namespace DavidTielke.PMA.UI.ConsoleClient;

class App
{
    private readonly IPersonDisplayCommands _displayCommands;

    public App(IPersonDisplayCommands displayCommands)
    {
        _displayCommands = displayCommands;
    }

    public void Run()
    {
        _displayCommands.DisplayAllAdults();
        _displayCommands.DisplayAllChildren();
    }
}