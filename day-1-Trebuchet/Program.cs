using System.Text.RegularExpressions;

// get input file from user input
Console.WriteLine("Enter the path to the input file:");
var path = Console.ReadLine();
var lines = File.ReadLines(path ?? throw new InvalidOperationException());
var sum = lines.Select(line => Regex.Matches(line, @"\d")
        .Select(m => m.Value)
        .ToArray())
    .Aggregate(0, (current, digits) => current + int.Parse($"{digits[0]}{digits[^1]}"));

Console.WriteLine($"The sum of all the concatenated digit lines is: {sum}");
