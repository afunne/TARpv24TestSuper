﻿namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");

            int number = 201;

            //kontrollitakse kas arv on suurem 189-st
            if (number > 189)
            {
                //kui vastab if tingimustele, siis n´itab konsoolis seda arvu
                Console.WriteLine("Number is bigger");

                //if ja else nestimine
                if (number > 190 && number <= 200)
                {
                    Console.WriteLine("Number is between 190 to 200");
                }
                else
                {
                    Console.WriteLine("Number is bigger than 200");
                }
            }
            else
            {
                Console.WriteLine("Number is smaller");


        }
        }
    }
}
