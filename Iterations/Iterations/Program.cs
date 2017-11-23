using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 1; i < 10; i++) //even nos.between 1-10 in ascending order
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
       
            }
            //Console.WriteLine();  //line break

            for (var i = 10; i >= 1; i--) //even nos.between 1-10 in descending order
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";
            foreach (var character in name) //In each step of the iteration the variable character holds 1 character.
            {
                Console.WriteLine(character);
            }

            //foreach example using array
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number); ;
            }


            while(true)
            {
                Console.Write("Type your name: "); //cursor is on the sameline. no line break
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;    //continue to the beginning of the while loop
                }
                break;
            }

        }
    }
}
