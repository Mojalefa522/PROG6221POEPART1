using System;
using System.Media;

namespace PROG6221POEPART1
{
    class Program
    {
        static string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return "User";

            name = name.Trim().ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        static void PlayWelcomeAudio()
        {
            try
            {
                string path = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "welcome.wav"
                );

                if (System.IO.File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Load();
                    player.PlaySync();
                }
            }
            catch
            {
            }
        }

        static void ShowBanner()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("||   |        \\ /      \\  /      \\ |       \\                  ||");
            Console.WriteLine("||   | $$$$$$$$|  $$$$$$\\|  $$$$$$\\| $$$$$$$\\                 ||");
            Console.WriteLine("||   | $$__    | $$___\\$$| $$   \\$$| $$__/ $$                 ||");
            Console.WriteLine("||   | $$  \\    \\$$    \\ | $$      | $$    $$                 ||");
            Console.WriteLine("||   | $$$$$    _\\$$$$$$\\| $$   __ | $$$$$$$\\                 ||");
            Console.WriteLine("||   | $$_____ |  \\__| $$| $$__/  \\| $$__/ $$                 ||");
            Console.WriteLine("||   | $$     \\ \\$$    $$ \\$$    $$| $$    $$                 ||");
            Console.WriteLine("||    \\$$$$$$$$  \\$$$$$$   \\$$$$$$  \\$$$$$$$                  ||");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("||                CYBERSECURITY CHATBOT SYSTEM                ||");
            Console.Write("||                         ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("EMMIE");
            Console.ResetColor();
            Console.WriteLine("                              ||");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("================================================================");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PlayWelcomeAudio();
            ShowBanner();

            Console.Write("Please enter your name: ");
            string nameInput = Console.ReadLine();
            string userName = FormatName(nameInput);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Emmie");
            Console.ResetColor();
            Console.WriteLine($": Hello {userName}! Welcome to the cybersecurity chatbot.");
            Console.WriteLine();

            ChatBot bot = new ChatBot(userName);
            bot.Start();

            Console.ReadKey();
        }
    }
}