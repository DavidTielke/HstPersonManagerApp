﻿using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonParser : IPersonParser
{
    public Person Parse(string dataLines)
    {
        var parts = dataLines.Split(',');
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
        return person;
    }
}