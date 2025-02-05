using System.Security.Cryptography.X509Certificates;

namespace ProjectNameButCooler
{
    class Program
    {
        static void Main()
        {


            for (int i = 0; i < 1000; i++)
            {
                Color c = (Color)(new Random()).Next(0, 5);
                switch (c)
                {
                    case Color.Red:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red");
                        Console.Beep();
                        break;
                    case Color.Green:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green");
                        Console.Beep();
                        break;
                    case Color.Blue:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue");
                        Console.Beep();
                        break;
                    case Color.White:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White");
                        Console.Beep();
                        break;
                    case Color.Orange:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Orange");
                        Console.Beep();
                        break;
                    default:
                        break;
                }
                Console.ResetColor();
            }
        }
        public enum Color
        {
            Red, Green, Blue, White, Orange
        }
    }
}
