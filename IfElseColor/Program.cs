using System.Xml.Linq;

namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thanks to bil Gates for supporting C# forum, thank you :3
            //This code is just a test tbh
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //I am asking the user for the input
            string color = Console.ReadLine();

            //checking
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
            }
            else
            {
            Console.WriteLine("viga");
            }

            if (color == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
            }
            else
            {
                Console.WriteLine("viga");
            }

            if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
            }
            else
            {
                Console.WriteLine("viga");
            }

            if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("White");
            }
            else
            {
                Console.WriteLine("viga");
            }



            if (color == "")
            {
                Console.WriteLine(">:|");
            }
            //Mr Dereviski pls dont kill me for this horiable code, thank you :>
        }
    }
}
