using Bot.Data;
using System.Collections.Generic;

namespace Bot
{
    public class TaskEngine
    {
        public List<TaskItem> Tasks = new();

        public void Add(TaskItem task) => Tasks.Add(task);

        public void Delete(int id)
        {
            Tasks.RemoveAll(t => t.Id == id);
        }

        public void Complete(int id)
        {
            var task = Tasks.Find(t => t.Id == id);
            if (task != null) task.Completed = true;
        }
    }
}