using System;
using System.IO;
using TextFileAnalyzer.Models;

namespace TextFileAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the path of the text file to analyze:");
                string filePath = Console.ReadLine();

                string[] lines = File.ReadAllLines(filePath);

                AnalysisResult analysisResult = TextAnalyzer.AnalyzeText(lines);

                DisplayResults(analysisResult);

                Console.WriteLine("\nDo you want to analyze another file? (y/n)");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer != "y")
                {
                    // If they type anything other than "y", end the loop
                    break;
                }
            }
            Console.WriteLine("Exiting the program. Have a great day!");
        }

        private static void DisplayResults(AnalysisResult result)
        {
            Console.WriteLine("\nAnalysis Results:");
            Console.WriteLine($"- Total Lines: {result.LineCount}");
            Console.WriteLine($"- Total Words: {result.TotalWords}");
            Console.WriteLine($"- Total Characters (with spaces): {result.TotalCharsWithSpaces}");
            Console.WriteLine($"- Total Characters (without spaces): {result.TotalCharsWithoutSpaces}");

            Console.WriteLine("\nTop 5 Most Frequent Words:");
            foreach (var wf in result.WordFrequencies.Take(5))
            {
                Console.WriteLine($"Word: '{wf.Word}' - Count: {wf.Count}");
            }
        }
    }
}