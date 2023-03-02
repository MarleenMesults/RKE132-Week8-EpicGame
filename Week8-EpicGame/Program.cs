
string folderPath = @"C:\Users\Torusiil\Desktop\data";
string heroFile = "Heroes.txt";
string villainFile = "Villains.txt";

string[] heros = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
//string[] heros = { "Margus", "luke Skywalker", "lara Croft" };
//string[] villains = { "Maksuamet", "Darth Vader", "Dracula", "Joker", "Sauron" };

string[] weapon = { "Labidas", "shovel", "lopata", "spade", "en una pala", "à la pelle" };



string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();  
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}