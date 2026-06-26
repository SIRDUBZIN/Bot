using System.Collections.Generic;
using System.IO;

namespace Bot
{
    public class ActivityLogger
    {
        public List<string> Logs = new();

        public void Log(string msg)
        {
            Logs.Add(msg);
            File.AppendAllText("log.txt", msg + "\n");
        }
    }
}