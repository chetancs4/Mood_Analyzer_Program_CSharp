namespace Mood_Analyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a message: ");
            string inputMessage = Console.ReadLine();

            MoodAnalyser moodAnalyser = new MoodAnalyser(inputMessage);
            string mood = moodAnalyser.AnalyseMood();

            Console.WriteLine($"Mood: {mood}");
        }
    }
}