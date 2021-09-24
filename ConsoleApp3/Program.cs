using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int input = 0;
            int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine("Heres your number:" + Factorial(input));


        }
        
        static double Factorial(int number)
        {

            if(number==0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
