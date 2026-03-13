using System;

namespace PROG6221POEPART1
{
    class ChatBot
    {
        void ShowTyping()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Emmie is typing...");
            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
        }

        void TypeBotReply(string message)
        {
            ShowTyping();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Emmie");
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
            else if (input == "2" || input.Contains("phishing"))
                return "2";
            else if (input == "3" || input.Contains("safe browsing") || input.Contains("browsing"))
                return "3";
            else if (input == "4" || input.Contains("how are you"))
                return "4";
            else if (input == "0" || input.Contains("exit") || input.Contains("quit"))
                return "0";

            return input;
        }

        void HandleChoice(string choice, ref bool running)
        {
            switch (choice)
            {
                case "1":
                    TypeBotReply("Strong passwords should include letters, numbers, and symbols.");
                    break;

                case "2":
                    TypeBotReply("Phishing scams try to trick you into revealing personal information.");
                    break;

                case "3":
                    TypeBotReply("Always check for HTTPS when entering sensitive information online.");
                    break;

                case "4":
                    TypeBotReply("I'm doing great! I'm here to help you stay safe online.");
                    break;

                case "0":
                    TypeBotReply("Goodbye! Stay safe online :).");
                    running = false;
                    break;

                default:
                    TypeBotReply("I didn't understand that option. Try typing a number or a topic name.");
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