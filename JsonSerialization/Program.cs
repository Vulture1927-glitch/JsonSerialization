using Classes;
using System.Text.Json;
public class Program
{
    static void Main()
    {
        Character hero = new Character()
        {
            Name = "The Man",
            ClassType = "Warrior",
            Level = 5,
            Health = 120,
            Mana = 10,
        };

        string path = @"C:\Users\isaac.stumm\source\repos\JsonSerialization\JsonSerialization\Data.json";
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        string convert = JsonSerializer.Serialize(hero, options);
        File.WriteAllText(path, convert);
        Console.WriteLine(convert);

        string text = File.ReadAllText(path);
        Character theReturn = JsonSerializer.Deserialize<Character>(text);
        Console.WriteLine(theReturn.Name);
        Console.WriteLine(theReturn.ClassType);
        Console.WriteLine(theReturn.Level);
        Console.WriteLine(theReturn.Health);
        Console.WriteLine(theReturn.Mana);

    }
}