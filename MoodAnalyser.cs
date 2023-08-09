namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            // Basic logic to determine mood based on keywords
            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "Happy Mood";
            }
            else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "Sad Mood";
            }
            else
            {
                return "Unable to determine mood";
            }
        }
    }
}