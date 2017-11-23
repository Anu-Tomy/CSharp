using System;

namespace Conditionals_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number. The number should be between 1 to 10.

            Exercise1();

            //Write a program which takes two numbers from the console and displays the maximum of the two.

            Exercise2();

            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            Exercise3();

            //write a program for a speed camera

            Exercise4();

        }
        public static void Exercise1()
        {
            /* Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
             a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
             applications where values entered into input boxes need to be validated.)
             */
            Console.WriteLine("Enter a number between 1-10");

            var num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Exercise2()
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter number1");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Maximum is " + max);
        }

        public static void Exercise3()
        {
            //Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            Console.WriteLine("Enter width of the image");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of the image");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else
            {
                Console.WriteLine("Image is portrait");
            }
        }
        public static void Exercise4()
        {
            /*
             * Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
             * If the user enters a value less than the speed limit, program should display Ok on the console. 
             * If the value is above the speed limit, the program should calculate the number of demerit points. 
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
             * If the number of demerit points is above 12, the program should display License Suspended.
           */
            Console.WriteLine("Enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of this car");
            var speed = Convert.ToInt32(Console.ReadLine());


            if (speed > limit)
            {
                var demerit_points = (speed - limit) / 5;
                if (demerit_points > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points = " + demerit_points);
                }
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}


