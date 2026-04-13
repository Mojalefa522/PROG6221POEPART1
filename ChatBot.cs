using System;

namespace PROG6221POEPART1
{
    class ChatBot
    {
        string userName;

        public ChatBot(string name)
        {
            userName = name;
        }

        void ShowTyping()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("BotManta is typing...");
            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
        }

        void TypeBotReply(string message)
        {
            ShowTyping();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("BotManta:");
            Console.ResetColor();
            Console.Write(": ");

            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(20);
            }

            Console.WriteLine();
        }

        void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.WriteLine("+                    CYBERSECURITY TOPICS MENU                 +");
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.ResetColor();

            Console.WriteLine("1 - Password Safety");
            Console.WriteLine("2 - Phishing");
            Console.WriteLine("3 - Safe Browsing");
            Console.WriteLine("4 - How are you?");
            Console.WriteLine("0 - Exit");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");
            Console.ResetColor();
            Console.WriteLine();
        }

        string NormalizeChoice(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "";

            input = input.Trim().ToLower();

            if (input == "1" || input.Contains("password"))
                return "1";
            else if (input == "2" || input.Contains("phishing") || input.Contains("scam"))
                return "2";
            else if (input == "3" || input.Contains("safe browsing") || input.Contains("safe"))
                return "3";
            else if (input == "4" || input.Contains("how are you"))
                return "4";
            else if (input == "0" || input.Contains("exit") || input.Contains("quit") || input.Contains("close"))
                return "0";

            return input;
        }

        void HandleChoice(string choice, ref bool running)
        {
            switch (choice)
            {
                case "1":
                    TypeBotReply($"{userName}, strong passwords should include letters, numbers, and symbols .eg:{userName}_156");
                    break;

                case "2":
                    TypeBotReply($"{userName}, phishing scams try to trick you into revealing personal information.eg:websites that tell you that you will win an Iphone 16 Ultra Pro Max if you sign up and send R5000.");
                    break;

                case "3":
                    TypeBotReply($"{userName}, always check for HTTPS when entering sensitive information online,this will appear at the top of the search bar before the name/address of the website.");
                    break;

                case "4":
                    TypeBotReply($"I'm doing great, {userName}! I'm here to help you stay safe online , Feel free to ask any more question about online Safety from the above list");
                    break;

                case "0":
                    TypeBotReply($"Goodbye, {userName}! Stay safe online ;).");
                    running = false;
                    break;

                default:
                    TypeBotReply($"{userName}, I didn't understand that option. Try typing a number or a topic name or EXIT");
                    break;
            }
        }

        public void Start()
        {
            bool running = true;

            while (running)
            {
                ShowMenu();

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                string choice = NormalizeChoice(input);

                Console.WriteLine();

                HandleChoice(choice, ref running);
            }
        }
    }
}