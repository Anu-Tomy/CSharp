using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            If the user doesn't provide any values, consider it as invalid time.
            */

            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            var inputTime = Console.ReadLine();

            if ((!string.IsNullOrWhiteSpace(inputTime)))
            {
                var timeArray= inputTime.Split(':');
                if(timeArray.Length !=2)
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }
                var hour = Convert.ToByte(timeArray[0]);
                var min = Convert.ToByte(timeArray[1]);
                if((hour >= 0 && hour <= 23) && (min >=0 && min < 60))
                    {
                    Console.WriteLine("Ok");
                    }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
                
            }
        }
    }
}
