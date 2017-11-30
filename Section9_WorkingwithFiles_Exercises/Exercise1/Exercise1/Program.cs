using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the number of words.

            var path = @"C:\Documents\samplefile.txt";

            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var contentArray = content.Split(' ');
                Console.WriteLine("Number of words: " + contentArray.Length);
            }
        }
    }
}
