namespace Mood_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            MoodAnalyzer mood = new MoodAnalyzer("I am Happy");
            Console.WriteLine("Mood is " + mood.AnalyseMood());
        }
    }
}