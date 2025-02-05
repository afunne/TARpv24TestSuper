namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cube = new Random().Next(1,7);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said 1 ja oled luuser");
                    break;

                case 2:
                    Console.WriteLine("Said 2 ja oled luuser");
                    break;

                case 3:
                    Console.WriteLine("Said 3 ja oled käsk");
                    break;

                case 4:
                    Console.WriteLine("Said 4 ja oled nuh uh");
                    break;

                case 5:
                    Console.WriteLine("Said 5 ja oled hea");
                    break;

                case 6:
                    Console.WriteLine("Said 6 ja oled cheater");
                    break;
                default:
                    Console.WriteLine("Viga number");
                    break;

            }
    }
    }
}
