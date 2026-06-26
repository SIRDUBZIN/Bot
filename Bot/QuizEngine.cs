using System.Collections.Generic;

namespace Bot
{
    public class QuizEngine
    {
        public int Index = 0;
        public int Score = 0;

        public List<(string Q, string A)> Questions = new()
        {
            ("What is phishing?", "fake"),
            ("What is malware?", "harm"),
            ("What is VPN used for?", "privacy"),
            ("What is a strong password?", "complex"),
            ("What is hacking?", "unauthorized")
        };

        public string GetQuestion()
        {
            if (Index >= Questions.Count)
                return $"Quiz finished! Score: {Score}/15";

            return Questions[Index].Q;
        }

        public bool CheckAnswer(string input)
        {
            bool correct = input.ToLower().Contains(Questions[Index].A);

            if (correct) Score++;

            Index++;

            return correct;
        }

        public void Reset()
        {
            Index = 0;
            Score = 0;
        }
    }
}