namespace CalculatorSwitch
{
    internal class CalculatorSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Insert first  number and press enter");
            //string tuleb konvertida int andmetüübiks
            float firtsNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            float calculatorType = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number and press enter");
            //string tuleb konvertida int andmetüübiks
            int secondNr = int.Parse(Console.ReadLine());

            switch (calculatorType)
            {
                case 1:
                    float result = firtsNr + secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firtsNr + " + " + secondNr + " = " + result);
                    break;
            }

            switch (calculatorType)
            {
                case 2:
                    float result = firtsNr - secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firtsNr + " - " + secondNr + " = " + result);
                    break;
            }

            switch (calculatorType)
            {
                case 3:
                    float result = firtsNr * secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firtsNr + " * " + secondNr + " = " + result);
                    break;
            }

            switch (calculatorType)
            {
                case 4:
                    float result = firtsNr / secondNr;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine(firtsNr + " / " + secondNr + " = " + result);
                    break;

                default:
                    Console.WriteLine("Bro, not cool");
                    break;
            }   
        }
    }
} 