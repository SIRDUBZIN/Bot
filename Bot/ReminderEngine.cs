using Bot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace Bot
{
    public class ReminderEngine
    {
        private DispatcherTimer timer = new();

        public List<TaskItem> Tasks = new();

        public ReminderEngine()
        {
            timer.Interval = TimeSpan.FromSeconds(30);

            timer.Tick += (s, e) =>
            {
                foreach (var t in Tasks.ToList())
                {
                    if (!t.Completed && DateTime.Now >= t.ReminderDate)
                    {
                        MessageBox.Show("Reminder: " + t.Title);
                        Tasks.Remove(t);
                    }
                }
            };

            timer.Start();
        }
    }
}