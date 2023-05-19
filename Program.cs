namespace CollectionTest;
using System;  
using System.Configuration;  

class Program
{
    static void Main()
    {
        AttributeList? attributesFromDisk = new AttributeList();

        Race characterRace = new Race();
        string fileName = ReadSetting("fileName");
        
        AttributeList.ReadFromDisk(fileName, out attributesFromDisk);
        characterRace.BaseAttributes = attributesFromDisk;

        characterRace.DisplayRace();

        SpecialAbilities specialAbilities = new("Mesmerism","Like hypnotism.");
        specialAbilities.Display();

        Character bob = new Character();
        bob.CharacterSpecialAbilities=new("Mesmerism","Like hypnotism.");

    }

    static string ReadSetting(string key)  
    {  
        string result = "";
        try  
        {  
            var appSettings = ConfigurationManager.AppSettings;  
            result = appSettings[key] ?? "Not Found";
            return result;
        }  
        catch (ConfigurationErrorsException)  
        {  
            Console.WriteLine("Error reading app settings");
            return result;
        }  
    }  
}