namespace CollectionTest;

public class Attribute
{
    public string AttributeName { get; set; }
    public int AttributeValue { get; set; }

    public Attribute(string attributeName, int attributeValue)
    {
        AttributeName = attributeName;
        AttributeValue = attributeValue;
    }
}