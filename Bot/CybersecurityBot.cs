namespace Bot
{
    public class CybersecurityBot
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("password"))
                return "Use strong passwords with numbers, symbols, and 12+ characters.";

            if (input.Contains("phishing"))
                return "Phishing is fake messages pretending to be trusted companies.";

            if (input.Contains("malware"))
                return "Malware is harmful software like viruses and ransomware.";

            if (input.Contains("vpn"))
                return "VPN protects your privacy online.";

            if (input.Contains("privacy"))
                return "Avoid sharing personal information online.";

            return "Ask me about cybersecurity topics like phishing, malware, VPN, passwords.";
        }
    }
}