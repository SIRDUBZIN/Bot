namespace Bot.Core
{
    public class SentimentAnalyzer
    {
        public string Analyze(string msg)
        {
            msg = msg.ToLower();

            if (msg.Contains("sad"))
                return "I'm here to help you stay safe.";

            if (msg.Contains("angry"))
                return "Let's solve it calmly together.";

            return null;
        }
    }
}