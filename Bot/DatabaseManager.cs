using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Bot.Data
{
    public class DatabaseManager
    {
        private string conn =
        "Server=localhost;Database=CyberBotDB;Uid=root;Pwd=;";

        public void AddTask(TaskItem task) { }
        public void UpdateTask(TaskItem task) { }
        public void DeleteTask(int id) { }

        public List<TaskItem> GetTasks()
        {
            return new List<TaskItem>();
        }
    }
}