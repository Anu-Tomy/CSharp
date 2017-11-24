using System;

namespace Loops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            Exercise1();

            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            Exercise2();

            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            Exercise3();

            //Write a program that picks a random number between 1 and 10.
            Exercise4();
            
            //Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console
            Exercise5();
            
        }
        public static void Exercise1()
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        public static void Exercise2()
        {
            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                var input = Console.ReadLine();

                if (input != "ok")
                {
                    sum += Convert.ToInt32(input);
                    continue;
                }
                break;
            }
            Console.WriteLine("Sum of the numbers: " + sum);

        }

        public static void Exercise3()
        {
            //Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("Enter a number: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var fact = 1;

            if (n == 0)
            {
            Console.WriteLine("{0}!={1}", n, fact);
            }
            else
            {
            for (var i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("{0}! = {1}", n, fact);
            }
        }

        public static void Exercise4()
        {
            //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

           
            var number = new Random().Next(1,10);
            Console.WriteLine("Secret number is " + number);

                for (var i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Guess the No:");
                    var guessNo = Convert.ToInt32(Console.ReadLine());

                    if (guessNo == number)
                    {
                        Console.WriteLine("You Won");
                        return;
                    }
                }
                Console.WriteLine("You lost");
        }

        //Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. 
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        public static void Exercise5()
        {

            Console.WriteLine("Enter the numbers seperated by comma: ");

            var nums = Console.ReadLine().Split(',');
           
            var max = Convert.ToInt32(nums[0]);
            for (var i = 0; i < nums.Length; i++)
            {
                if (Convert.ToInt32(nums[i]) > max)
                {
                    max = Convert.ToInt32(nums[i]);
                }
            }
            Console.WriteLine("Max is " + max);

        }
       
    }
}
