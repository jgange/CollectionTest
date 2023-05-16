namespace CollectionTest;

public class AttributeList: List<Attribute>
{
    public AttributeList(params Attribute[] attributes)
    {
        foreach (var attribute in attributes?? Array.Empty<Attribute>())
        {
            if (attribute is null) 
            {
                continue;
            }
            Add(attribute);
        }
        if (Count == 0) 
        {
            throw new ArgumentNullException(nameof(attributes));
        }
    }

    public AttributeList()
    {
        
    }

    public void DisplayAttributeList(AttributeList attributes)
    {
        foreach(Attribute attribute in attributes)
        {
            Console.WriteLine(attribute.AttributeName + ": " + attribute.AttributeValue);
        }
    }
}