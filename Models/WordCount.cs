namespace TextFileAnalyzer.Models
{
    /// <summary>
    /// Represents a single word and how many times it appears in the text.
    /// </summary>
    public class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }
}