using System;
using System.Linq;
using System.Collections.Generic;
using TextFileAnalyzer.Models;

namespace TextFileAnalyzer
{
    public static class TextAnalyzer
    {
        /// <summary>
        /// Analyzes an array of text lines and returns an AnalysisResult object.
        /// </summary>
        /// <param name="lines">The lines of text to analyze.</param>
        /// <returns>An AnalysisResult with various statistics.</returns>
        public static AnalysisResult AnalyzeText(string[] lines)
        {
            int lineCount = lines.Length;

            // Join all lines to a single string for easier splitting
            string allText = string.Join(" ", lines);

            int totalCharsWithSpaces = allText.Length;

            int totalCharsWithoutSpaces = allText.Replace(" ", "").Length;

            char[] delimiters = { ' ', '.', ',', '!', '?', ':', ';', '\t', '\r', '\n' };
            List<string> words = allText
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())  // Convert to lower for case-insensitive counts
                .ToList();

            int totalWordCount = words.Count;

            List<WordCount> wordFrequency = words
                .GroupBy(w => w)
                .Select(g => new WordCount
                {
                    Word = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(wf => wf.Count)
                .ToList();

            return new AnalysisResult
            {
                LineCount = lineCount,
                TotalCharsWithSpaces = totalCharsWithSpaces,
                TotalCharsWithoutSpaces = totalCharsWithoutSpaces,
                TotalWords = totalWordCount,
                WordFrequencies = wordFrequency
            };
        }
    }
}