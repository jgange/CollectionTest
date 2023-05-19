namespace CollectionTest;

/*
    Race name - string
    Race type - string
    Taint - int value
    Base stats - list of name, value pairs
    Special abilities - list of ability names
    Traits - list of trait names
    Bonus skills - list of skill names
    Languages - list of languages
*/

class Race
{
    public string? RaceName { get; set; } = "Human";
    public string? RaceType { get; set; } = "Base Human";
    public int? StartingTaint { get; set; } = 0;

    public AttributeList? BaseAttributes {get; set;}
    
    public Race(AttributeList? attributes)
    {
        BaseAttributes = attributes;
    }

    public Race()
    {

    }
    public void DisplayRace()
    {
        Console.WriteLine("Race: " + RaceName);
        Console.WriteLine("Type: " + RaceType);
        Console.WriteLine("Taint:  " + StartingTaint);

        if (BaseAttributes != null)
        {
            Console.WriteLine("Base attributes:");
            AttributeList.DisplayAttributeList(BaseAttributes);
        }
    }

}