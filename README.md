Cybersecurity Awareness Bot
Overview
The Cybersecurity Awareness Bot is a WPF desktop application built in C#.  
It is designed to educate users about cybersecurity topics through an interactive chatbot, quiz system, and task manager.
The system uses a Bot1-style structure with modular classes, sound effects, and a cyber-themed UI.
Purpose
This project aims to:
- Educate users about cybersecurity threats
- Provide interactive learning (chat + quiz)
- Demonstrate WPF application development
- Show modular programming using multiple classes
- Features
Chatbot System
- Responds to cybersecurity questions
- Uses keyword-based NLP processing
- Gives educational responses
 Quiz System
- 15 cybersecurity questions
- Score tracking system
- Restart functionality
- Task Manager
- Add tasks
- Store tasks in memory
- Display task list
- Activity Logger
- Tracks user actions
- Displays system activity history
- Memory System
- Stores user data (name, topic, history)
- Saves data between sessions
Sound System
- Plays welcome sound on startup
- Uses embedded WAV resource (welcome.wav)
 UI Design
- Cyber-themed interface
- Background image (er.png)
- Dark overlay for readability
- 3-panel layout:
  - Left: Status & memory
  - Middle: Chat system
  - Right: Tasks & logs
  -  Technologies Used
- C#
- WPF (Windows Presentation Foundation)
- XAML
- .NET Framework
- System.Media (SoundPlayer)
