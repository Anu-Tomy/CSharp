﻿using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new System.DateTime(2017, 11, 19);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
        }

    }
}
       