using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            int suurus = int.Parse(Console.ReadLine());

            if (suurus >= 30 && suurus <= 33)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (suurus >= 34 && suurus <= 38)
                Console.BackgroundColor = ConsoleColor.White;
            {

            }
            if (suurus >= 39 && suurus <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (suurus >= 45 && suurus <= 48)
                Console.Beep();
            {
           


            }
            Console.WriteLine("sinu jala suurus on " + suurus);
        }
    }
}
