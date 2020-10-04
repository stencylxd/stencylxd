// My Website Code - stencylxd

#region Deps
using System;
using static System.Console;
using static System.ConsoleColor;
#endregion Deps

namespace Website
{
    public static class MainCode
    {
        public static string _Status = "Browsing menu...";
        public static float number = 0f;
        public static ConsoleKeyInfo _Input;
        public static bool GetInput() { _Input = new ConsoleKeyInfo(); if (KeyAvailable) _Input = ReadKey(true); return KeyAvailable; }
        static void Main()
        {
            _MainMenu:
            ResetView();
            WriteLine("Hello! My name is Leo Markley, or stencylxd.\n" +
                "I can write websites and computer software.\n" +
                "You can see most of my projects on Github.\n" +
                "The website you're on right now is written in C#, running in a repl.it\n");
            ForegroundColor = DarkGreen;
            Write("Github: ");
            ForegroundColor = White;
            WriteLine("https://github.com/stencylxd");
            WriteLine("Press 1 to play a game, or 2 to increase the number below.");
            WriteLine($"Your Number: {number}");
            while (true) {
                GetInput();
                if (_Input.Key == ConsoleKey.D1) goto _Game;
                if (_Input.Key == ConsoleKey.D2) { number++; goto _MainMenu; }
            }
            _Game:
            _Status = "Playing fun game.";
            ResetView();
            WriteLine("You get invited to a dinner party at a house.\n" +
                "You enter the house and come to a hallway. Right or left?\n\n" +
                "1: Right\n" + "2: Left");
            while (true) {
                GetInput();
                if (_Input.Key == ConsoleKey.D1) { Death("choked on a chicken drumstick"); goto _Game; }
                if (_Input.Key == ConsoleKey.D2) break;
            }
            ResetView();
            WriteLine("A bald man meets you. He tells you that you have cancer. Light him up?\n\n" +
                "1: Molotov Cocktail\n" + "2: Spare Him");
            while (true) {
                GetInput();
                if (_Input.Key == ConsoleKey.D1) break;
                if (_Input.Key == ConsoleKey.D2) { Death("died from cancer"); goto _Game; }
            }
            ResetView();
            WriteLine("Your friend says he's gonna fly a Boeing 737 MAX S3375 into the house.\n" +
                "Use your RF TV remote to implode him remotely?\n\n" +
                "1: Implode Him\n" + "2: Do it before he can");
            while (true) {
                GetInput();
                if (_Input.Key == ConsoleKey.D1) { Death("killed an innocent. The police will hang you up on the wall like a christmas decoration"); goto _Game; }
                if (_Input.Key == ConsoleKey.D2) break;
            }
            ResetView();
            WriteLine("The dinner party was amazing. You exploded the house and the surrounding neighborhood,\n" +
                "and you straight up killed everybody. You even called an airstrike on your brother's home.\n" +
                "You made alot of new friends and family and had a real fun time. The end."
            );
            Environment.Exit(0);
        }
        public static void ResetView() {
            BackgroundColor = DarkBlue;
            Clear();
            BackgroundColor = Blue;
            for (int x = 0; x < WindowWidth; x++)
                Write(" ");
            SetCursorPosition(0, 0);
            ForegroundColor = Red; Write("s");
            ForegroundColor = Green; Write("t");
            ForegroundColor = Yellow; Write("e");
            ForegroundColor = DarkRed; Write("n");
            ForegroundColor = DarkGreen; Write("c");
            ForegroundColor = DarkYellow; Write("y");
            ForegroundColor = Magenta; Write("l");
            ForegroundColor = DarkMagenta; Write("x");
            ForegroundColor = DarkRed; Write("d");
            ForegroundColor = White; Write(".");
            ForegroundColor = Green; Write("g");
            ForegroundColor = Yellow; Write("a");
            ForegroundColor = White;
            WriteLine($" - ({_Status})");
            BackgroundColor = DarkBlue;
            SetCursorPosition(0, 2);
        }

        public static void Death(string deathCause) {
            WriteLine($"\nYou {deathCause}.\n" +
                "Press any key to replay.");
            while (!KeyAvailable) {}
            ReadKey();
        }
    }
}
