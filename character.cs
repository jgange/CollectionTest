namespace CollectionTest;

class Character
{
    public AttributeList? CharacterAttributes { get; set; }
    public Race? CharacterRace { get; set; }
    public List<SpecialAbilities>? CharacterSpecialAbilities { get; set; }

    public Character() {}

    public Character(AttributeList attributes, List<SpecialAbilities> specialAbilities)
    {
        this.CharacterAttributes = attributes;
        this.CharacterRace.BaseAttributes = attributes;
        this.CharacterSpecialAbilities = specialAbilities;
    }

    public void DisplayCharacter()
    {
        this.CharacterRace.DisplayRace();
        AttributeList.DisplayAttributeList(CharacterAttributes);
        this.CharacterSpecialAbilities.Display();

    }

}