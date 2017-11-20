using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            var character = 'A';
            var totalPrice = 12.35f;
            var firstName = "ABC";
            var isWorking = true;
            const float Pi = 3.14f; 
            Console.WriteLine(number);
            Console.WriteLine(character);
            Console.WriteLine(totalPrice);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(Pi);
            /* using format string {0} and {1}
             * {0} represents first argument, (here byte.MinValue) and {1} represents second argument
             * */
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // outputs 0 255
            Console.WriteLine("{0} {1}", float.MinValue, byte.MaxValue);
        }
    }
}
