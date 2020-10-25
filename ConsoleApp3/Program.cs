using System;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using Colorful;
using System.Threading;
using Console = Colorful.Console;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            string userInput = "";
            string[] ascii = {@"
     .-.-.   .-.-.   .-.-.   .-.-.   .-.-.   .-.-.   .-.-.   .-.-    .-.-.   .-.-.   .-.-.   .-.-.   .-.-.   .-.-.   .-.-    .-.-.   .-.-.   .-.-.   .-.-.
    / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ / / \ \ 
   `-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-'   `-`-", @" 
                                          ___   ___   ___   _     __   _       __   _____  __    _     ____  ___   __  
                                         | |_) / / \ | | \ \ \_/ ( (` | |\ |  / /\   | |  / /`  | |_| | |_  | |_) ( (` 
                                         |_|_) \_\_/ |_|_/  |_|  _)_) |_| \| /_/--\  |_|  \_\_, |_| | |_|__ |_| \ _)_) 
                                              _   _              ___   ____  _     _     _       ___   ___   ___       
                                             | | | |\ |         | |_) | |_  | |   | |   \ \    // / \ / / \ | | \      
                                             |_| |_| \|         |_|_) |_|__ |_|__ |_|__  \_\/\/ \_\_/ \_\_/ |_|_/       
"};

            Console.Clear();
            WindowTransition();

            Console.WriteWithGradient(ascii[0], Color.Fuchsia, Color.Yellow, 3);

            Console.SetCursorPosition(0, 12);
            Console.WriteWithGradient(ascii[1], Color.Yellow, Color.Fuchsia, 10);

            Console.WriteLine("\n");
            WriteLineCenter("[1] Start  ");
            WriteLineCenter("[2] Options");
            WriteLineCenter("[3] About  ");
            WriteLineCenter("[4] Update ");
            WriteLineCenter("[5] Exit   ");

            Console.SetCursorPosition(0, 34);
            Console.WriteWithGradient(ascii[0], Color.Fuchsia, Color.Yellow, 3);

            Console.SetCursorPosition(0, 0);
            while (true)
            {
                userInput = Console.ReadKey(false).Key.ToString();
                switch (userInput) {
                    case "1":
                        // Start game
                        break;
                    case "2":
                        // Open options
                        break;
                    case "3":
                        // Open about page
                        break;
                    case "4":
                        // Update using zsync
                        break;
                    case "5":
                        // Exit game
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void WriteCenter(string text)
        {
            Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }

        static void WriteLineCenter(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }
        public async Task WindowTransition()
        {
            await Task.Run(() =>
                {
                    for (int i = 4; i < 160; i += 4)
                    {
                        Console.SetWindowSize(i, i / 4);
                        Thread.Sleep(2);
                    }
                    Console.SetBufferSize(160, 39);
                });
        }
    }
}
