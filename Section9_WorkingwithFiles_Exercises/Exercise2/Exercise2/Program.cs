using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the longest word in the file.
            var path = @"C:\Documents\samplefile.txt";
            if(File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var wordArray = content.Split(' ');
                var wordlength = 1;
                string longWord = " ";
                foreach(string word in wordArray)
                {
                    if(word.Length > wordlength)
                    {
                        longWord = word;
                    }
                }
                Console.WriteLine("Longest word is : " + longWord);
            }
        }
    }
}
