using System.Drawing;

namespace IfElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Okay, idk what to do here exsacly but im gonna make it work XD");
            
            Console.WriteLine("Enter first number");
            float NrTheFirst = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            float NrTheSecond = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            float ChoiseOfTheYear = float.Parse(Console.ReadLine());
            float result = 0;

            if (ChoiseOfTheYear == 1)
            {
                result = NrTheFirst + NrTheSecond;
                Console.WriteLine("Result: ");
                Console.WriteLine(NrTheFirst + " + " + NrTheSecond + " = " + result);
            }
            else if (ChoiseOfTheYear == 2)
            {
                result = NrTheFirst - NrTheSecond;
                Console.WriteLine("Result: ");
                Console.WriteLine(NrTheFirst + " - " + NrTheSecond + " = " + result);
            }
            else if (ChoiseOfTheYear == 3)
            {
                result = NrTheFirst * NrTheSecond;
                Console.WriteLine("Result: ");
                Console.WriteLine(NrTheFirst + " * " + NrTheSecond + " = " + result);
            }
            else if (ChoiseOfTheYear == 4)
            {
                result = NrTheFirst / NrTheSecond;
                Console.WriteLine("Result: ");
                Console.WriteLine(NrTheFirst + " / " + NrTheSecond + " = " + result);
            }
            else
                Console.WriteLine("Ur cringe, kys >:3");
        }
    }
}
