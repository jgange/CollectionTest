namespace CollectionTest;
﻿using System.Text.Json;

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

    public AttributeList() {}

    static public bool updateAttribute(AttributeList attributelist, string attributeName, int attributeValue)
    {
        //expect an Attribute and search for the AttributeName and change the associated value
        //return true if successfully updated value, false if the value is missing
        bool found = false;

        foreach(Attribute item in attributelist)
        {
            if(item.AttributeName == attributeName)
            {
                item.AttributeValue = attributeValue;
            }    
        }
        return found;
    }

    static public void DisplayAttributeList(AttributeList attributes)
    {
        foreach(Attribute attribute in attributes)
        {
            Console.WriteLine(attribute.AttributeName + ": " + attribute.AttributeValue);
        }
    }

    static public void ReadFromDisk(string fileName, out AttributeList? attributesFromDisk)
    {
        using (StreamReader r = new StreamReader(fileName))  
        {  
            string? json = r.ReadToEnd();
            attributesFromDisk = JsonSerializer.Deserialize<AttributeList>(json);       
        }
    }

    static public void WriteToDisk(string fileName, AttributeList? attributes)
    {
        var systemJsonReadable = JsonSerializer.Serialize(attributes, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        Console.WriteLine(systemJsonReadable);
        Console.WriteLine();
        File.WriteAllText(fileName, systemJsonReadable);
    }

}

