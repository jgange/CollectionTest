﻿namespace CollectionTest;
﻿using System.Text.Json;

class Program
{
    static void Main()
    {
        string fileName = @"./attributes.json";

        //List<Attribute>? attributesFromDisk = new List<Attribute>();
        AttributeList? attributesFromDisk = new AttributeList();

        //AttributeList.ReadFromDisk(fileName, out attributesFromDisk);

        // need to add ability to add new items as well as modify what is saved to the file

        Attribute strength = new Attribute("Strength", 12);
        Attribute dextertity = new Attribute("Dexterity", 12);

        AttributeList attributes = new AttributeList(strength, dextertity);

        AttributeList.DisplayAttributeList(attributes);

        AttributeList.WriteToDisk(fileName, attributes);

        if (attributesFromDisk!=null)
        {
            AttributeList.DisplayAttributeList(attributes);
        }
    }
}