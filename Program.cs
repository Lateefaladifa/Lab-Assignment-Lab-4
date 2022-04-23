using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To check the sum of two numbers is lessthan 100");
            Console.Write("insert the first number... ");
            int FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Insert the second number... ");
            int SecondNumber = int.Parse(Console.ReadLine()); 
             int Result = FirstNumber + SecondNumber;

            if (Result <= 100)
            {
                Console.WriteLine("Return True!!");
            }
            else
            {
                Console.WriteLine("Return False!!");
            }
            

        }
    }
}
