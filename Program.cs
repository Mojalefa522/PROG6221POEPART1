using System;

namespace PROG6221POEPART1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("||   |        \\ /      \\  /      \\ |       \\                  ||");
            Console.WriteLine("||   | $$$$$$$$|  $$$$$$\\|  $$$$$$\\| $$$$$$$\\                 ||");
            Console.WriteLine("||   | $$__    | $$___\\$$| $$   \\$$| $$__/ $$                   ||");
            Console.WriteLine("||   | $$  \\    \\$$    \\ | $$      | $$    $$                 ||");
            Console.WriteLine("||   | $$$$$    _\\$$$$$$\\| $$   __ | $$$$$$$\\                 ||");
            Console.WriteLine("||   | $$_____ |  \\__| $$| $$__/  \\| $$__/ $$                   ||");
            Console.WriteLine("||   | $$     \\ \\$$    $$ \\$$    $$| $$    $$                 ||");
            Console.WriteLine("||    \\$$$$$$$$  \\$$$$$$   \\$$$$$$  \\$$$$$$$                  ||");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("||                CYBERSECURITY CHATBOT SYSTEM                ||");
            Console.WriteLine("||                         EMMIE                              ||");
            Console.WriteLine("||                                                            ||");
            Console.WriteLine("================================================================");
            Console.WriteLine();

            Console.WriteLine("Hello! I'm Emmie, your cybersecurity chatbot.");
            Console.WriteLine("I can help you learn how to stay safe online.");
            Console.WriteLine();

            bool running = true;

            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("What would you like help with?");
                Console.WriteLine("1 - Password Safety");
                Console.WriteLine("2 - Phishing");
                Console.WriteLine("3 - Safe Browsing");
                Console.WriteLine("4 - How are you?");
                Console.WriteLine("0 - Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Emmie: Strong passwords should include letters, numbers, and symbols.");
                        break;

                    case "2":
                        Console.WriteLine("Emmie: Phishing scams try to trick you into revealing personal information.");
                        break;

                    case "3":
                        Console.WriteLine("Emmie: Always check for HTTPS when entering sensitive information online.");
                        break;

                    case "4":
                        Console.WriteLine("Emmie: I'm doing great! I'm here to help you stay safe online.");
                        break;

                    case "0":
                        Console.WriteLine("Emmie: Goodbye! Stay safe online.");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Emmie: I didn't understand that option.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}