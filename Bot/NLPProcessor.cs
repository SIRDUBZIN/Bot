namespace Bot
{
    public class NLPProcessor
    {
        public string Process(string input)
        {
            input = input.ToLower();

            if (input.StartsWith("add task")) return "ADD_TASK";
            if (input.StartsWith("delete task")) return "DELETE_TASK";
            if (input.StartsWith("complete task")) return "COMPLETE_TASK";
            if (input.Contains("show tasks")) return "SHOW_TASKS";
            if (input.Contains("quiz")) return "START_QUIZ";
            if (input.Contains("activity log")) return "SHOW_LOG";

            return "CHAT";
        }
    }
}