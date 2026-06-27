# Prog6221-Part3-Boitumelo
Chatbot POE
Project Name

Cyber Crime Fighting Bot – Part 3

Project Description

The Cyber Crime Fighting Bot is a Windows Forms (C#) desktop application designed to educate users about cybersecurity while providing useful productivity features.

The application combines:
An intelligent cybersecurity chatbot
A cybersecurity awareness quiz
A task management assistant with reminders
A SQL Server database for storing tasks
Basic Natural Language Processing (NLP) simulation
Activity logging
A login screen for personalised interaction

The chatbot helps users learn about online safety by responding to cybersecurity questions, remembering user preferences, recognising keywords, detecting simple emotions, and maintaining conversation context.

Software Required

To run this project you will need:

Microsoft Visual Studio 2022
.NET Framework (same version used in the project)
SQL Server Express or SQL Server
SQL Server Management Studio (SSMS)
Windows Operating System
How to Open and Run the Project
Download or clone the repository.
Open Visual Studio.
Select Open a project or solution.
Open the solution (.sln) file.
Restore any missing packages if prompted.
Ensure SQL Server is running.
Build the solution by selecting

Database Setup Instructions
The Task Assistant uses a SQL Server database.
Step 1:
Open SQL Server Management Studio.
Step 2:
Create a database called:CyberCrimeBotDB
Step 3:
Execute the SQL script included in the project to create the Tasks table.
Example:

CREATE TABLE Tasks
(
    TaskID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100),
    Description NVARCHAR(255),
    ReminderDate DATETIME,
    Status NVARCHAR(20)
);
Step 4:
Open the project in Visual Studio.
Step 5:
Open:DatabaseHelper.cs
Step 6:
Update the SQL connection string to match your SQL Server instance.
Example:
Server=YOUR_SERVER_NAME;
Database=CyberCrimeBotDB;
Trusted_Connection=True;
Step 7:
Save the project and rebuild.

Login System

When the application starts, the user is presented with a login screen.
The user enters their name and clicks Start.
After successful login:
the chatbot becomes available
the Task Assistant becomes available
the Cyber Quiz becomes available
The chatbot personalises responses using the user's name.
Using the Chat Assistant
The Chat Assistant is located on the Chat Assistant tab.
Users can:ask cybersecurity questions,select cybersecurity topics,chat naturally,receive cybersecurity advice andhear the welcome voice greeting

The chatbot supports conversations about:

Password Safety
Phishing
Privacy
Safe Browsing
Social Engineering
Scams

How to Test the NLP Simulation
The chatbot includes a simple Natural Language Processing simulation.
Test the following examples:
Greetings
Hello
Hi
Keyword Recognition
Tell me about phishing
Password safety
Follow-up Questions
Tell me more
Give me more tips
Memory
My favourite topic is phishing
Then ask:
Remember my favourite topic

Sentiment Detection

Try typing:I am worried,I am sad andI am excited.The chatbot responds differently depending on the detected emotion.

Using the Task Assistant
Open the Task Manager tab.
Users can:add tasks,add descriptions,select reminder dates,view tasks,mark tasks as completed and delete tasks.All task information is stored inside the SQL Server database.

How to Access the Quiz / Mini-Game
Open the Cyber Quiz tab.
Press:Start Quiz
The quiz presents cybersecurity multiple-choice questions.Features include:score tracking,feedback after every answer,explanation of correct answers,question counter,final percentage score,restart quiz functionality and the Activity Log.The activity log allows users to review actions performed while using the application.

Important Notes
The user must enter a name before accessing the application.
SQL Server must be running before using the Task Assistant.
Ensure the database connection string matches your SQL Server installation.
The audio files used for the welcome greeting must remain inside the project folder.
If using another computer, update the SQL connection string accordingly.

Video Presentation Link: https://youtu.be/0S-tkmD7tMA
