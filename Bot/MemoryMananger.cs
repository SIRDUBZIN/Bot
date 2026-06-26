using System.Collections.Generic;
using System.IO;

namespace Bot
{
    public class MemoryManager
    {
        public string UserName;
        public string FavouriteTopic;
        public List<string> History = new();

        public void Save()
        {
            File.WriteAllLines("memory.txt", new[]
            {
                UserName ?? "",
                FavouriteTopic ?? ""
            });
        }

        public void Load()
        {
            if (!File.Exists("memory.txt")) return;

            var lines = File.ReadAllLines("memory.txt");

            if (lines.Length > 0) UserName = lines[0];
            if (lines.Length > 1) FavouriteTopic = lines[1];
        }
    }
}