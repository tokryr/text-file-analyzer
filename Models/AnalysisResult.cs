using System.Collections.Generic;

namespace TextFileAnalyzer.Models
{
    /// <summary>
    /// Holds the overall results of the text analysis.
    /// </summary>
    public class AnalysisResult
    {
        public int LineCount { get; set; }
        public int TotalCharsWithSpaces { get; set; }
        public int TotalCharsWithoutSpaces { get; set; }
        public int TotalWords { get; set; }
        public List<WordCount> WordFrequencies { get; set; }
    }
}