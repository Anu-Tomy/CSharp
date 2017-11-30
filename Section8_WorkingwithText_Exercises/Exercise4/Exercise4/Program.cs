using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
             * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
             */

            Console.WriteLine("Enter a few words separated by a space");
            var input = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(input))
            {
                string[] words = input.Split(' ');

                //Combine the words with PascalCase
                string PascalCase = "";
                foreach(string word in words)
                {
                    PascalCase += word.Substring(0, 1).ToUpper() + word.ToLower().Substring(1);  
                }
                Console.WriteLine("PascalCase: " + PascalCase); 
            }
        }
    }
}
