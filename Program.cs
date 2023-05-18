namespace CollectionTest;
using System;  
using System.Configuration;  

class Program
{
    static void Main()
    {
        AttributeList attributes = new AttributeList(
            new Attribute("Strength",10),
            new Attribute("Dexterity",10),
            new Attribute("Constitution",10),
            new Attribute("Intellect",10),
            new Attribute("Power",10),
            new Attribute("Size",10)
        );

        Race characterRace = new Race();
        characterRace.RaceName = "Human";
        characterRace.RaceType = "Base human";
        characterRace.baseAttributes = attributes;

        characterRace.DisplayRace();

        ReadSetting("fileName");  
    }

    static void ReadSetting(string key)  
    {  
        try  
        {  
            var appSettings = ConfigurationManager.AppSettings;  
            string result = appSettings[key] ?? "Not Found";  
            Console.WriteLine(result);  
        }  
        catch (ConfigurationErrorsException)  
        {  
            Console.WriteLine("Error reading app settings");  
        }  
    }  
}