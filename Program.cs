// See https://aka.ms/new-console-template for more information
using System;

namespace Exercises
{

    public class Exercise2
    {
        static void Main(string[] args)
        {
            Console.Title = "Admin";


            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < number1; row++)
            {

                for (int column = number1; column > row; column--)
                {
                        Console.Write($"{number}");
                }
                Console.Write('\n');
            }

            // Exercise 3

            var userID = "AANAR";

            Console.Write("Enter your userID: ");
            var userid = Console.ReadLine();

            var userPassword = 553311;

            Console.Write("Enter your Password: ");
            var userpassword = Convert.ToInt32(Console.ReadLine());

            int count_wrong_attempts = 0;
            if ((userID == userid) && (userPassword == userpassword))
            {
                Console.WriteLine("Welcome back my dear friend!");
                Console.WriteLine("I am very happy to see you again!!");
            }
            else if ((userID != userid) && (userPassword != userpassword))
            {
                count_wrong_attempts += 1;
                if (count_wrong_attempts == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are rejected.Pls try later! ");

                }
                    Console.Write("Enter your userID: ");
                    userid = Console.ReadLine();
                    
                    Console.Write("Enter your Password: ");
                    userpassword = Convert.ToInt32(Console.ReadLine());


            }

            Console.ReadKey();
        }
    }
}
