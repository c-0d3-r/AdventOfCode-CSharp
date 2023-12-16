using System.Text.RegularExpressions;

var projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
var filePath = Path.Combine(projectDirectory!, "input.txt");

if (!File.Exists(filePath))
{
    Console.WriteLine("File does not exist.");
    return;
}

using var reader = new StreamReader(filePath);
var sum = 0;

while (reader.ReadLine() is { } line)
{
    string numbers = Regex.Replace(line, @"[^\d]", "");
    int firstNumber = int.Parse(numbers[..1]);
    int lastNumber = int.Parse(numbers[^1..]);

    int number = firstNumber * 10 + lastNumber;
    sum += number;
}

Console.WriteLine(sum);