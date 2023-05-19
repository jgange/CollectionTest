namespace CollectionTest;
using System;  
using System.Configuration;  

class Program
{
    static void Main()
    {
        AttributeList? attributesFromDisk = new AttributeList();

        Race characterRace = new Race();
        characterRace.RaceName = "Human";
        characterRace.RaceType = "Base human";
        string fileName = ReadSetting("fileName");
        //characterRace.baseAttributes = 
        AttributeList.ReadFromDisk(fileName, out attributesFromDisk);
        

        characterRace.DisplayRace();
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