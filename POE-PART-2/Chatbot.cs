﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART_2
{
    internal class Chatbot
    {
        private string userName;
        private string userInterest;
        private Dictionary<string, List<string>> responses;
        private Dictionary<string, string> keywords;
        private Random random;

        public Chatbot() {
            random = new Random();
            InitializeResponses();
            InitializeKeywords();

        }
        private void InitializeResponses()
        {
            responses = new Dictionary<string, List<string>>
            {
                ["phishing"] = new List<string>
                {
                    "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations.",
                    "Always verify the sender's email address before clicking any links. When in doubt, contact the organization directly.",
                    "Look out for urgent language like 'Act now!' or 'Limited time offer!' - these are common phishing tactics.",
                    "Never provide passwords or sensitive information via email. Legitimate companies won't ask for this information.",
                    "Check for spelling errors and poor grammar - these are often signs of phishing attempts."
                },
                ["password"] = new List<string>
                {
                    "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.",
                    "Consider using a password manager to generate and store complex passwords securely.",
                    "Use a combination of uppercase, lowercase, numbers, and symbols for stronger passwords.",
                    "Change your passwords regularly, especially if you suspect they've been compromised.",
                    "Enable two-factor authentication whenever possible for an extra layer of security."
                },
                ["scam"] = new List<string>
                {
                    "Be skeptical of unsolicited calls or messages asking for money or personal information.",
                    "Research any investment opportunities thoroughly before committing your money.",
                    "Never give out your banking details to someone who contacts you unexpectedly.",
                    "If something sounds too good to be true, it probably is. Trust your instincts.",
                    "Verify the identity of anyone claiming to be from a company or government agency."
                },
                ["privacy"] = new List<string>
                {
                    "Review your social media privacy settings regularly to control who can see your information.",
                    "Be mindful of what personal information you share online - it can be used against you.",
                    "Use privacy-focused browsers and search engines to limit data collection.",
                    "Read privacy policies before agreeing to terms and conditions on websites and apps.",
                    "Consider using a VPN when browsing on public Wi-Fi networks."
                },
                  ["software updates"] = new List<string>
                {
                    "Regularly updating software plays an important role in protecting your data.",
                    "Outdated software often contains vulnerabilities that can be exploited by malicious actors to gain access to systems and data.",
                    "Software updates often include patches that address known vulnerabilities.",
                    "Updates may introduce new security features or enhancements that can strengthen your system’s defenses",
                    "Keeping software up to date helps to mitigate the risks associated with using outdated technology."
                },
                 ["Session hijacking"] = new List<string>
                {
                    "Make sure that your website uses HTTPS to encrypt data transmitted between your site and the users. ",
                    "Logging out of websites after you are done is important because once you log out, the session ID is invalid and cannot be used maliciously.",
                    "Many session hijacking attacks take advantage of stolen credentials; however, with MFA even if cybercriminals get your login credentials, they won’t be able to access your account without the second authentication requirement. ",
                    "Before clicking on a link, make sure that it is safe to do so. Some links may look legitimate but instead of taking you to the website you’re looking for, they may direct you to a malicious phishing site that’s trying to get you to enter your password or install malware.",
                    "Public WiFi isn’t secure, and it’s easy for cybercriminals to hijack sessions through Man-in-the-Middle attacks. If possible, avoid public WiFi completely."
                },
               
                ["Ransomware"] = new List<string>
                {
                    "Immediately disconnect the infected computers, laptops or tablets from all network connections, whether wired, wireless or mobile phone based.",
                    "Reset credentials including passwords (especially for administrator and other system accounts) - but verify that you are not locking yourself out of systems that are needed for recovery.",
                    "Safely wipe the infected devices and reinstall the OS.",
                    "Paying the ransom is risky as there is no gaurentee that the criminals will give your system back to you and your computer will still be infected,",
                    "Install, update, and run antivirus software."
                },
                ["DNS spoofing"] = new List<string>
                {
                    "Never click a link you do not recognize",
                    "Manually enter a Uniform Resource Locator (URL) into your web browser than click on a link that may look suspicious. Clicking the wrong link can lead to a DNS attack.",
                    "Regularly scanning your computer for infections can get rid of malware you downloaded accidentally as a result of DNS poisoning.",
                    "Flushing the DNS cache gives your device a fresh start, ensuring that any DNS information that gets processed will correlate with the correct site.",
                    "With a virtual private network (VPN), all data going to and from your computer is encrypted. You can connect to a private DNS server that only connects using encryption.",
                },
                
            };
        }
        private void InitializeKeywords()
        {
            keywords = new Dictionary<string, string>
            {
                ["password"] = "password",
                ["passwords"] = "password",
                ["login"] = "password",
                ["phishing"] = "phishing",
                ["phish"] = "phishing",
                ["email"] = "phishing",
                ["scam"] = "scam",
                ["scams"] = "scam",
                ["fraud"] = "scam",
                ["fraudulent"] = "scam",
                ["privacy"] = "privacy",
                ["private"] = "privacy",
                ["personal"] = "privacy",
                ["data"] = "privacy",
                ["update"] = "software udpate",
                ["updates"] = "software udpate",
                ["session"] = "session hijacking",
                ["sessions"] = "session hijacking",
                ["hijacking"] = "session hijacking",
                ["HTTPS"] = "session hijacking",
                ["ransom"] = "ransomware",
                ["hostage"] = "ransomware",
                ["DNS"] = "DNS spoofing",
                ["url"] = "DNS spoofing",
                ["link"] = "DNS spoofing"


            };
        }
        //Play voice greeting
        public void Greeting()
        {
            SoundPlayer Greeting1 = new SoundPlayer(@"C:\Users\lab_services_student\source\repos\POE\POE\Cybersecurity awareness bot WAV.wav");
            Greeting1.Play();
        }
        // acsii art


        public void ImageDisplay()
        { //Image was generated using an online acsii generator 
            Console.Write(@"                                                                                                    
                                                                                                    
        @""]
    ____ ___ _____   ____  _   _ ____  ______   ___ 
| __ )_ _|_   _| | __ )| | | |  _ \|  _ \ \ / / |
|  _ \| |  | |   |  _ \| | | | | | | | | \ V /| |
| |_) | |  | |   | |_) | |_| | |_| | |_| || | |_|
|____/___| |_|   |____/ \___/|____/|____/ |_| (_)
                   Awareness bot v1.0
              ");

        }
        //Displays a border
        public void DisplayBorder()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=================================================================");
            Console.ResetColor(); ;//this setting and resetting of colors are to make the UI more visually appealing
        }
        //Displays the Logo+ A nice welcoming message to formally weclome the user to the program
        public void WelcomeGreeting()
        {
            ImageDisplay();
            DisplayBorder();
            Console.WriteLine($"Greetings mortal, I am bitbuddy :) ,your personalized chatbot from CyberSads!");
            Console.WriteLine("I am here to help you surf the web in a safe and secure way ;)");
            DisplayBorder();

        }


        public void GetUserName()
        {
            Console.Write("\nWhat's your name? ");
            userName = Console.ReadLine();
        }

        public void DisplayWelcome()
        {
            Console.Clear();
            ImageDisplay();
            DisplayBorder();
            Console.WriteLine($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I'm here to help you learn about online safety.");
            DisplayBorder();
        }
        private string DetectSentiment(string input)//Detects sentiment based on words that envoke a certain emtion
        {
            string lowerInput = input.ToLower();

            if (lowerInput.Contains("worried") || lowerInput.Contains("scared") || lowerInput.Contains("afraid") ||
                lowerInput.Contains("anxious") || lowerInput.Contains("concerned"))
                return "worried";

            if (lowerInput.Contains("frustrated") || lowerInput.Contains("annoyed") || lowerInput.Contains("angry"))
                return "frustrated";

            if (lowerInput.Contains("curious") || lowerInput.Contains("interested") || lowerInput.Contains("want to know"))
                return "curious";

            if (lowerInput.Contains("confused") || lowerInput.Contains("don't understand") || lowerInput.Contains("unclear"))
                return "confused";

            return "neutral";

        }
        private string GetSentimentResponse(string sentiment)// takes sentiment that was detected from user and responds to user accordingly
        {
            switch (sentiment)
            {
                case "worried":
                    return "It's completely understandable to feel that way. Cybersecurity can seem overwhelming, but I'm here to help you feel more confident. ";
                case "frustrated":
                    return "I understand your frustration. Let me try to explain this in a simpler way. ";
                case "curious":
                    return "Great! I love your curiosity about cybersecurity. ";
                case "confused":
                    return "No worries! Let me break this down for you step by step. ";
                default:
                    return "";
            }
        }
         private string RecognizeKeyword(string input)// recognizes keyword that wa
 {
     string lowerInput = input.ToLower();
     
     foreach (var keyword in keywords)
     {
         if (lowerInput.Contains(keyword.Key))
         {
             return keyword.Value;
         }
     }
     
     return null;
 }
        
        private string GetRandomResponse(string topic)//loops through dictionary and gives a random response based off of the keyword that was selected
        {
            if (responses.ContainsKey(topic) && responses[topic].Count > 0)
            {
                int index = random.Next(responses[topic].Count);
                return responses[topic][index];
            }
            return null;
        }
        public void HandleUserInput(string userInput) //Where user input is processed
        {
            string sentiment = DetectSentiment(userInput);
            string sentimentResponse = GetSentimentResponse(sentiment);
            string recognizedKeyword = RecognizeKeyword(userInput);

            // Tracks what user is interested in based on 
            if (userInput.ToLower().Contains("interested in") || userInput.ToLower().Contains("i like"))
            {
                if (recognizedKeyword != null)
                {
                    userInterest = recognizedKeyword;
                    Console.WriteLine(sentimentResponse + $"Great! I'll remember that you're interested in {recognizedKeyword}. It's a crucial part of staying safe online.");
                    return;
                }
            }

            // Handle predefined menu options
            if (userInput.Contains("1") || userInput.Contains("how are you"))
            {
                Console.WriteLine(sentimentResponse + "I'm doing well, thanks for asking :) ! I'm ready to help with cybersecurity information.");
                if (!string.IsNullOrEmpty(userInterest))
                {
                    Console.WriteLine($"Since you're interested in {userInterest}, would you like to see some tips about this specific topic?");
                }
            }
            else if (userInput.Contains("2") || userInput.Contains("what is your purpose?"))
            {
                Console.WriteLine(sentimentResponse + "My purpose is to spread awareness on cybersecurity help you surf the web safely by teaching you online safety practices :) .");
            }
            else if (userInput.Contains("3") || userInput.Contains("what questions can i ask?"))
            {
                Console.WriteLine(sentimentResponse + "You can ask me about certain cybersecurity topics such as password security, phishing, scams, privacy protection, ransomware, DNS spoofing, session hijacking and software updates.");
            }
            else if (recognizedKeyword != null)
            {
                // Handle keyword recognition with random responses
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{recognizedKeyword.ToUpper()} SECURITY TIPS:");
                Console.ResetColor();

                string randomResponse = GetRandomResponse(recognizedKeyword);
                if (randomResponse != null)
                {
                    Console.WriteLine(sentimentResponse + randomResponse);
                }
                else
                {
                    Console.WriteLine(sentimentResponse + $"Here's some important information about {recognizedKeyword} security.");
                }

                // Personalized follow-up based on user interest
                if (userInterest == recognizedKeyword)
                {
                    Console.WriteLine($"As someone particularly interested in {userInterest}, you might want to explore this topic further!");
                }
            }
            else if (userInput.ToLower().Contains("more") || userInput.ToLower().Contains("tell me more") ||
                     userInput.ToLower().Contains("explain") || userInput.ToLower().Contains("details"))
            {
                // Handle follow-up questions
                Console.WriteLine(sentimentResponse + "I'd be happy to provide more details! What specific aspect would you like me to explain further?");
                Console.WriteLine("You can ask about passwords, phishing, scams, or privacy protection.");
            }
            else
            {
                Console.WriteLine(sentimentResponse + $"I'm sorry, {userName}, I don't have specific information about that yet.");
                Console.WriteLine("You can ask me about cybersecurity topics such as password security, phishing, scams, privacy protection, ransomware, DNS spoofing, session hijacking or software updates.");

                if (!string.IsNullOrEmpty(userInterest))
                {
                    Console.WriteLine($"Or would you like to know more about {userInterest}, which you mentioned you're interested in?");
                }
            }
        }
           public void SayGoodbye()
   {
       if (!string.IsNullOrEmpty(userInterest))
       {
           Console.WriteLine($"Goodbye, {userName}! Remember to keep practicing good {userInterest} habits. Stay safe online!");
       }
       else
       {
           Console.WriteLine($"Goodbye, {userName}! Stay safe online!");
       }
   }
 public void ConversationStarter()
 {
     bool exitProgram = false;
     
     while (!exitProgram)
     {
         Console.WriteLine($"\nWhat would you like to know about, {userName}? (Type 'exit' to end)");
         Console.WriteLine("1. How are you?");
         Console.WriteLine("2. What's your purpose?");
         Console.WriteLine("3. What can I ask you about?");
         Console.WriteLine("You can also ask about: passwords, phishing, scams, privacy, or any cybersecurity topic!");
         
         string userInput = Console.ReadLine();
         
         if (string.IsNullOrEmpty(userInput))
         {
             Console.WriteLine("Please enter something so I can help you!");
             continue;
         }
         
         Console.Clear();
         
         if (userInput.ToLower().Contains("exit") || userInput.ToLower().Contains("bye") || 
             userInput.ToLower().Contains("goodbye") || userInput.ToLower().Contains("quit"))
         {
             exitProgram = true;
             SayGoodbye();
         }
         else
         {
             HandleUserInput(userInput);
             
             Console.WriteLine("\nPress any key to continue...");
             Console.ReadKey();
             Console.Clear();
             ImageDisplay();
         }
     }
 }

    }
}
