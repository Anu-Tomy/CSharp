using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter numbers seperated by hyphen");
            var input = Console.ReadLine();
                      
            var numList = new List<int>();

            var values = input.Split('-');

            foreach (var value in values)
            {
                numList.Add(Convert.ToInt32(value));
            }
            
            numList.Sort();
            
            for(var i = 0; i < numList.Count; i++)
            {
                if (numList[i + 1] == numList[i] + 1)
                {
                    Console.WriteLine("Consecutive");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
                
            }
        }
    }
}
