namespace CollectionTest;

class Race
{
    public string? RaceName { get; set; }
    public string? RaceType { get; set; }
    public int? StartingTaint { get; set; }

    public AttributeList? baseAttributes {get; set;}

    public void DisplayRace()
    {
        Console.WriteLine("Race: " + RaceName);
        Console.WriteLine("Type: " + RaceType);
        if (baseAttributes != null)
        {
            Console.WriteLine("Base attributes:");
            AttributeList.DisplayAttributeList(baseAttributes);
        }
    }

}