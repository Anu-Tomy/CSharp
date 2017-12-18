using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3]; // same as int numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);  // 1
            Console.WriteLine(numbers[1]);  // 0    by default initialized to 0
            Console.WriteLine(numbers[2]);  // 0


            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);  //true
            Console.WriteLine(flags[1]); //false  - default value
            Console.WriteLine(flags[2]); //false 

            var names = new string[3] { "Jack", "John", "Mary"};

            Console.WriteLine(names[0]); //Jack
            Console.WriteLine(names[1]); //John 
            Console.WriteLine(names[2]); //Mary 
        }
    }
}
