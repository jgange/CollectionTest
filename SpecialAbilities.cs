namespace CollectionTest;

class SpecialAbilities
{
    public string? SpecialAbilityName { get; set; }
    public string? SpecialAbilityShortDescription { get; set; }

    public SpecialAbilities(string specialAbilityName, string specialAbilityShortDescription)
    {
        SpecialAbilityName = specialAbilityName;
        SpecialAbilityShortDescription = specialAbilityShortDescription;
    }

    public SpecialAbilities() {}

    public void Display()
    {
        Console.WriteLine(SpecialAbilityName);
        Console.WriteLine(SpecialAbilityShortDescription);
        Console.WriteLine();
    }
}