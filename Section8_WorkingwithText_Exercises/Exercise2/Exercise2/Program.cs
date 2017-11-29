using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately;
            //otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

            Console.WriteLine("Enter numbers seperated by hyphen");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            if (!(string.IsNullOrWhiteSpace(input)))
            {
                var values = input.Split('-');
                foreach (var value in values)
                {
                    numbers.Add(Convert.ToInt32(value));
                }
                
                var uniques = numbers.Distinct(); //seperate unique numbers

                var uniqList = new List<int>();

                foreach (var num in uniques)
                {
                    uniqList.Add(num);
                }

                if (!(numbers.Count == uniqList.Count))
                {
                    Console.WriteLine("Duplicate");
                }
                else
                {
                    Console.WriteLine("No Duplicates");
                }
            }
            
        } 
    }
}
