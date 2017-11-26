using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10) // All these methods can be appended because all these return a StringBuilder
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 5)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);
            
            Console.WriteLine("First character: " + builder[0]);
        }
    }
}
