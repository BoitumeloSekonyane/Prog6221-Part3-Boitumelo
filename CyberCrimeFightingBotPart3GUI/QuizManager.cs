using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CyberCrimeFightingBotPart2GUI
{
    public class QuizManager
    {
        //using a list and automatic properties
        public List <QuizQuestions>Questions { get; set; }

            public QuizManager()
        {
            Questions = new List<QuizQuestions>();

            LoadQuestions();
        }
        private void LoadQuestions()
        {
            
            //Question 01:
            Questions.Add(new QuizQuestions
            { 
                Question = "What is the most common type of cybercrime?",
                OptionA = "Phishing",
                OptionB = "Identity theft",
                OptionC = "Ransomware",
                OptionD = "Hacking",

                CorrectAnswer = "A",

                Explanation = "Phishing is the most common type of cybercrime, where attackers trick individuals into revealing sensitive information."
            });

            //Question 02:
            Questions.Add(new QuizQuestions
            {
                Question = "True or False: You should reuse the same password everywhere.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",

                CorrectAnswer = "B",

                Explanation = "Reusing passwords increases security risks."
            });

            //Question 03:
            Questions.Add(new QuizQuestions
            {
                Question = "What does 2FA stand for?",
                OptionA = "Two-Factor Authentication",
                OptionB = "Two File Access",
                OptionC = "Two Firewall Accounts",
                OptionD = "Second File Approval",

                CorrectAnswer = "A",

                Explanation = "2FA adds an extra security layer."
            });

            //Question 04:
            Questions.Add(new QuizQuestions
            {
                Question = "Which website is more secure?",
                OptionA = "http://bank.com",
                OptionB = "https://bank.com",
                OptionC = "bank.txt",
                OptionD = "bank.exe",

                CorrectAnswer = "B",

                Explanation = "HTTPS encrypts data."
            });

            //Question 05:
            Questions.Add(new QuizQuestions
            {
                Question = "True or False: Public Wi-Fi is always safe.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",

                CorrectAnswer = "B",

                Explanation = "Public Wi-Fi can expose your data."
            });

            //Question 06:
            Questions.Add(new QuizQuestions
            {
                Question = "What is social engineering?",
                OptionA = "Building websites",
                OptionB = "Manipulating people for information",
                OptionC = "Programming",
                OptionD = "Data encryption",

                CorrectAnswer = "B",

                Explanation = "Social engineering exploits human trust."
            });

            //Question 07:
            Questions.Add(new QuizQuestions
            {
                Question = "What is ransomware?",
                OptionA = "A type of malware that locks files",
                OptionB = "A firewall",
                OptionC = "An antivirus program",
                OptionD = "A secure password manager",
                CorrectAnswer = "A",
                Explanation = "Ransomware encrypts files and demands payment."
            });
            //Question 08:
            Questions.Add(new QuizQuestions
            {
                Question = "Which is the strongest password?",
                OptionA = "password123",
                OptionB = "John2025",
                OptionC = "P@55w0rd!8x#",
                OptionD = "123456",

                CorrectAnswer = "C",

                Explanation = "Complex passwords are harder to crack."
            });

            //Question 09:
            Questions.Add(new QuizQuestions
            {
                Question = "True or False: You should click on links in unsolicited emails.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",

                CorrectAnswer = "B",

                Explanation = "Clicking on links in unsolicited emails can lead to phishing attacks."
            });

            //Question 10:
            Questions.Add(new QuizQuestions
            {
                Question = "True or False: Software updates improve security.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",

                CorrectAnswer = "A",

                Explanation = "Updates often patch vulnerabilities."
            });

            //Question 11:
            Questions.Add(new QuizQuestions
            {
                Question = "What should you do with suspicious emails?",
                OptionA = "Open immediately",
                OptionB = "Forward to everyone",
                OptionC = "Verify sender first",
                OptionD = "Ignore security warnings",

                CorrectAnswer = "C",

                Explanation = "Always verify suspicious emails."
            });
            //Question 12:
            Questions.Add(new QuizQuestions
            {
                Question = "What protects a network?",
                OptionA = "Firewall",
                OptionB = "Keyboard",
                OptionC = "Printer",
                OptionD = "Monitor",

                CorrectAnswer = "A",

                Explanation = "Firewalls filter network traffic."
            });
            //Question 13:
            Questions.Add(new QuizQuestions
            {
                Question = "True or False: Antivirus software is useless.",
                OptionA = "True",
                OptionB = "False",
                OptionC = "",
                OptionD = "",

                CorrectAnswer = "B",

                Explanation = "Antivirus software helps detect threats."
            });
            //Question 14:
            Questions.Add(new QuizQuestions
            {
                Question = "What is malware?",
                OptionA = "Malicious software",
                OptionB = "Secure software",
                OptionC = "Cloud storage",
                OptionD = "A browser",

                CorrectAnswer = "A",

                Explanation = "Malware is harmful software."
            });

        }
    }
}

