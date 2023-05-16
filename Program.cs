namespace CollectionTest;
﻿using System.Text.Json;

class Program
{
    static void Main()
    {
        string fileName = @"./attributes.json";

        //List<Attribute>? attributesFromDisk = new List<Attribute>();
        AttributeList? attributesFromDisk = new AttributeList();
  
        using (StreamReader r = new StreamReader(fileName))  
        {  
            string? json = r.ReadToEnd();
            attributesFromDisk = JsonSerializer.Deserialize<AttributeList>(json);
             
        }

        /*
        Attribute strength = new Attribute("Strength", 12);
        Attribute dextertity = new Attribute("Dexterity", 12);

        AttributeList attributes = new AttributeList(strength, dextertity);

        attributes.DisplayAttributeList(attributes);

        var systemJsonReadable = JsonSerializer.Serialize(attributes, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        Console.WriteLine(systemJsonReadable);
        Console.WriteLine();
        File.WriteAllText(fileName, systemJsonReadable);
        */

        if (attributesFromDisk!=null)
        {
            attributesFromDisk.DisplayAttributeList(attributesFromDisk);
        }
    }
}