using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandLists_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
                Exercise1();

            //Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
                Exercise2();

            //Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
                Exercise3();

            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
                Exercise4();

            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
                Exercise5();
        }

        public static void Exercise1()
        {
            /*  When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
               * If no one likes your post, it doesn't display anything.
               * If only one person likes your post, it displays: [Friend's Name] likes your post.
               * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
               * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
               Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
               Depending on the number of names provided, display a message based on the above pattern.
            */

            Console.WriteLine("Enter your friends names(press Enter to finish): ");
            var friends = new List<string>();

            while(true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                friends.Add(input);
            }

            if(friends.Count == 1)
            {
                Console.WriteLine("{0} like your post", friends[0]);
            }
            else if(friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post", friends[0], friends[1]);
            }
            else if (friends.Count > 2)
            {
                Console.WriteLine("{0},{1} and {2} others like your post", friends[0], friends[1], (friends.Count - 2));
            }
            else
            {
                //Console.WriteLine("No likes");
                Console.WriteLine();
            }

        }

        public static void  Exercise2()
        {
            /*
             * Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
             * Display the reversed name on the console.
            */

            Console.WriteLine("Enter your name: ");
            var reversed = new string(Console.ReadLine().ToCharArray().Reverse().ToArray());
           // var input = Console.ReadLine();
           // Array.Reverse(input.ToCharArray());
           // var reversed = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Reversed name : " + reversed);            
        }

        public static void Exercise3()
        {
            /*
             * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. 
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */
            int[] nums = new int[5];

            Console.WriteLine("Enter 5 numbers");
            for (var i = 0; i < 5; i++)
            {
               var input = Convert.ToInt32(Console.ReadLine());
               
                if(nums.Contains(input))
                {
                    Console.WriteLine("Please enter unique numbers");
                    i--;
                    continue;
                }
                nums[i] = input;              
            }
            //Sort the Array
           Array.Sort(nums);

            Console.WriteLine("Sorted Numbers: ");
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static void Exercise4()
        {
            /*
             * Write a program and ask the user to continuously enter a number or type "Quit" to exit.
             * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            */
           
            Console.Write("Enter numbers continuously or type 'Quit' to exit: ");
            var numbers = new List<int>();
                        
            while (true)
            {
               var input = (Console.ReadLine());

                if (input.ToLower() == "quit" || string.IsNullOrEmpty(input)) //break the loop when user type Quit or press Enter
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            var uniquenums = numbers.Distinct();
            Console.WriteLine("Unique numbers: ");
            foreach(var num in uniquenums)
            {
                Console.WriteLine(num);
            }
        }
        
        public static void Exercise5()
        {
            /*
             * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
             * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
             * otherwise, display the 3 smallest numbers in the list.
           */

            var numbers = new List<int>();

                while (true)
                {
                    Console.WriteLine("Enter atleast 5 numbers seperated by comma");
                    var input = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Invalid List. Retry");
                    }
                    
                    var values = input.Split(',');
                
                    foreach(var value in values)
                    {
                       numbers.Add(Convert.ToInt32(value));
                    }


                if ((numbers.Count) < 5)
                {
                    Console.WriteLine("Invalid List. Retry");
                }
                else
                {
                    break;
                }
        }

            numbers.Sort();

            Console.WriteLine();
            Console.WriteLine("The three smallest numbers are: ");
            for (var i = 0; i < 3; i++)
            {
               Console.WriteLine(numbers[i]);
            }        
                       
        }
    
    }
}
