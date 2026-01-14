namespace DavidTielke.PMA.CrossCutting.DataClasses;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car() { }

    public Car(int id, string brand, string model, int year)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
    }
}
