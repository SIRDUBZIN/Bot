using System.Media;
using System.Windows;
using System.Windows.Input;

namespace Bot
{
    public partial class MainWindow : Window
    {
        CybersecurityBot bot = new();
        NLPProcessor nlp = new();
        QuizEngine quiz = new();
        TaskEngine taskEngine = new();
        ReminderEngine reminderEngine = new();
        MemoryManager memory = new();
        ActivityLogger logger = new();

        public MainWindow()
        {
            InitializeComponent();
            memory.Load();
            PlayWelcomeSound();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessInput();
        }

        private void UserInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ProcessInput();
        }

        private void ProcessInput()
        {
            string input = UserInputTextBox.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            AddUser(input);

            string command = nlp.Process(input);

            switch (command)
            {
                case "CHAT":
                    AddBot(bot.GetResponse(input));
                    break;

                case "START_QUIZ":
                    AddBot(quiz.GetQuestion());
                    break;

                case "ADD_TASK":
                    taskEngine.Add(new TaskItem { Title = input, Id = taskEngine.Tasks.Count + 1 });
                    AddBot("Task added");
                    logger.Log("Task added");
                    break;

                case "SHOW_TASKS":
                    foreach (var t in taskEngine.Tasks)
                        AddBot(t.Title);
                    break;

                case "SHOW_LOG":
                    foreach (var l in logger.Logs)
                        AddBot(l);
                    break;
            }

            memory.History.Add(input);
            memory.Save();

            UserInputTextBox.Clear();
        }

        private void AddUser(string msg)
        {
            ChatPanel.Children.Add(new System.Windows.Controls.TextBlock
            {
                Text = "You: " + msg
            });
        }

        private void AddBot(string msg)
        {
            ChatPanel.Children.Add(new System.Windows.Controls.TextBlock
            {
                Text = "Bot: " + msg
            });
        }
        private void StartQuizButton_Click(object sender, RoutedEventArgs e)
        {
            quiz.Reset();
            AddBot("Quiz started!");
            AddBot(quiz.GetQuestion());
        }

        private void RestartQuizButton_Click(object sender, RoutedEventArgs e)
        {
            quiz.Reset();
            AddBot("Quiz restarted!");
        }

        private void ShowLogButton_Click(object sender, RoutedEventArgs e)
        {
            AddBot("=== ACTIVITY LOG ===");

            foreach (var log in logger.Logs)
                AddBot(log);
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var task = new TaskItem
            {
                Id = taskEngine.Tasks.Count + 1,
                Title = TaskTextBox.Text,
                Completed = false,
                ReminderDate = DateTime.Now.AddMinutes(1)
            };

            taskEngine.Add(task);

            AddBot("Task added: " + task.Title);
            logger.Log("Task added: " + task.Title);

            TaskTextBox.Clear();
        }
        private void PlayWelcomeSound()
        {
            try
            {
                SoundPlayer player =
                    new SoundPlayer(Bot.Properties.Resources.welcome);

                player.Play();
            }
            catch
            {
                // ignore errors if file missing
            }
        }
    }
}