using System;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string inputFilePath = "input.txt";  // Replace with your input file path
        string outputFilePath = "output.txt";  // Replace with your output file path

        // Read the string from the input file
        string s = File.ReadAllText(inputFilePath);

        // Format the string
        string formattedString = FormatString(s);

        // Write the formatted string to the output file
        File.WriteAllText(outputFilePath, formattedString);

        Console.WriteLine($"Formatted string written to {outputFilePath}");
    }

    public static string FormatString(string s)
    {
        // Remove periods
        s = s.Replace(".", "");

        // Add ":" every 2 elements
        string formattedString = string.Join(":", Enumerable.Range(0, s.Length / 2).Select(i => s.Substring(i * 2, 2)));

        // Convert to uppercase
        formattedString = formattedString.ToUpper();

        return formattedString;
    }
}
