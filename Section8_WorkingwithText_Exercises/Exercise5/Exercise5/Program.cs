using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
             * So, if the user enters "inadequate", the program should display 6 on the console
             */
            Console.WriteLine("Enter an English word");
            string word = Console.ReadLine().ToLower();//ToLower() is used to count both A and a

            if(!string.IsNullOrWhiteSpace(word))
            {

                var vowels = new List<char>() { 'a','e','i','o','u'};
                var count = 0;
                foreach(var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        count++;
                    }
                }
                Console.WriteLine("No.of vowels: " + count);
            }
        }
    }
}
