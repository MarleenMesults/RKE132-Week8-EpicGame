string path = @"C:\Users\Torusiil\Desktop\data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

showFileContent(lines);

static void showFileContent(string[] fileContentArray)
{
    int i = 0;
    foreach (string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {line}");
        i++;
    }

}