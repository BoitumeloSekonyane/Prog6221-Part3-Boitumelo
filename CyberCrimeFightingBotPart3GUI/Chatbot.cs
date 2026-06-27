using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using CyberCrimeFightingBotPart2GUI;

namespace CyberCrimeFightingBotPart2GUI
{

        public class Chatbot
        {
                //fields of the chatbot
            private User user;

            private Random random = new Random();

            private string currentTopic = "";
        //This dictionary is used to store the index of each topic in the keywordResponses dictionary. This allows the chatbot to keep track of which topic the user is currently interested in and provide relevant responses based on that topic. It also helps the chatbot to remember the user's favourite topic and recall it when asked, creating a more personalized experience.
        private Dictionary<string, int> topicIndexes = new Dictionary<string, int>();

            // Dictionary for keywords and responses
            private Dictionary<string, List<string>> keywordResponses;

            public Chatbot(User user)
            {
                this.user = user;

                keywordResponses = new Dictionary<string, List<string>>()
            {

                {
                    "password",
                    new List<string>()
                    {
                        "Remember to use a strong password with letters, numbers, and symbols.",
                        "Do not reuse passwords across different websites.",
                        "Consider using a password manager."
                    }
                },

                    {
                        "my purpose",
                        new List<string>()
                        {
                            "I am here to help you learn about cybersecurity and how to stay safe online.",
                            "My purpose is to provide you with tips and information to protect yourself from cyber threats.",
                            "I want to empower you with knowledge about cybersecurity so you can navigate the digital world safely."
                        }
                    },

                {
                    "phishing",
                    new List<string>()
                    {
                        "Be careful of emails asking for personal information.",
                        "Always verify email senders before clicking links.",
                        "Phishing emails often create urgency to scare users."
                    }
                },

                {
                    "privacy",
                    new List<string>()
                    {
                        "Use privacy settings on social media.",
                        "Avoid oversharing personal information online.",
                        "Enable two-factor authentication for extra privacy."
                    }
                },

                {
                    "scam",
                    new List<string>()
                    {
                        "Be careful of offers that seem too good to be true.",
                        "Never send money to strangers online.",
                        "Report scams immediately."
                    }
                },

                {
                    "safe browsing",
                    new List<string>()
                    {
                        "Keep your browser updated.",
                        "Avoid suspicious downloads.",
                        "Use secure websites that begin with HTTPS."
                    }
                },

                    {
                        "social engineering",
                        new List<string>()
                        {
                            "Be cautious of unsolicited requests for information.",
                            "Verify identities before sharing sensitive data.",
                            "Social engineering attacks often exploit human psychology."
                        }
                    }
            };
            }

            // Voice greeting
            public void PlayVoiceGreeting(string filePath)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error playing sound: " + ex.Message);
                }
            }

            // Main chatbot response method
            public string RespondToUserInput(string input)
            {
                input = input.ToLower();

                // MEMORY FEATURE
                if (input.Contains("my favourite topic is") ||
                    input.Contains("i like") ||
                    input.Contains("i would like to talk about"))
                {
                    foreach (var keyword in keywordResponses.Keys)
                    {
                        if (input.Contains(keyword))
                        {
                            user.FavouriteTopic = keyword;
                            currentTopic = keyword;

                            return "Great! I will remember that your favourite topic is " + keyword + ".";
                        }
                    }
                }

            // The sentiment detetction uses the current topic to provide a more empathetic response based on the user's feelings. This allows the chatbot to connect with the user on a more personal level and provide support or encouragement related to the topic they are interested in.
            if (input.Contains("sad") ||
                    input.Contains("upset") ||
                    input.Contains("frustrated"))
                {
                    return "I understand how you feel." + currentTopic + "can feel overwhelming sometimes.";
                }

                if (input.Contains("worried"))
                {
                    return "It is understandable to feel worried. Social Engineering tactics can be convincing. Always verify suspicious emails and never share personal information with unknown senders/exeternal parties.";
                }

                if (input.Contains("happy") ||
                    input.Contains("excited"))
                {
                    return "That is great to hear!";
                }

                // FOLLOW-UP QUESTIONS
                if (input.Contains("tell me more") ||
                    input.Contains("give me more tips") ||
                    input.Contains("i am interested in"))
                {
                    if (currentTopic != "")
                    {
                        return GetRandomResponse(currentTopic);
                    }

                    return "Please tell me which cybersecurity topic you want to learn more about.";
                }

            // the Keyword Recognition allows the chatbot to identify specific cybersecurity topics mentioned by the user and provide relevant information or tips. This makes the conversation more dynamic and tailored to the user's interests, enhancing their learning experience.
            foreach (var keyword in keywordResponses.Keys)
                {
                    if (input.Contains(keyword))
                    {
                        currentTopic = keyword;

                        return GetRandomResponse(keyword);
                    }
                }

            // the Memory Feature allows the chatbot to remember the user's favourite cybersecurity topic and recall it when asked. This creates a more personalized experience and shows that the chatbot is attentive to the user's preferences, making the interaction feel more engaging and human-like.
            if (input.Contains("remember") ||
                    input.Contains("my favourite topic"))
                {
                    if (!string.IsNullOrEmpty(user.FavouriteTopic))
                    {
                        return "Your favourite cybersecurity topic is " + user.FavouriteTopic + ".";
                    }

                    return "You have not shared your favourite topic yet.";
                }

            // If the user greets the chatbot, it will respond with a friendly greeting and ask how it can assist them with cybersecurity topics. This sets a welcoming tone for the conversation and encourages the user to engage with the chatbot.
            if (input.Contains("hello") ||
                    input.Contains("hi"))
                {
                    return "Hello " + user.Name + "! How can I help you stay safe online today?";
                }

                // DEFAULT RESPONSE
                return "I am not sure I understand. Can you try rephrasing your concern or interest?";
        }

        // The Random Response method ensures that the chatbot provides varied and dynamic responses to the user, preventing repetitive answers and keeping the conversation engaging. By cycling through different responses for each topic, the chatbot can maintain the user's interest and encourage them to explore more about cybersecurity.
private string GetRandomResponse(string keyword)
        {
            List<string> responses = keywordResponses[keyword];

            // If topic not tracked yet
            if (!topicIndexes.ContainsKey(keyword))
            {
                topicIndexes[keyword] = 0;
            }

            int index = topicIndexes[keyword];

            string response = responses[index];

            // Move to next response
            topicIndexes[keyword]++;

            // Restart if at end
            if (topicIndexes[keyword] >= responses.Count)
            {
                topicIndexes[keyword] = 0;
            }

            return response;
        }

        // ASCII Art
        
public string GetAsciiArt()
        {
            return @"

   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██║  ██║██║   ██║   ██║
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝    ╚═╝

                    CYBERBOT
            ";
        }

    }
}



