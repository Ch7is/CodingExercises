using System;
using System.Linq;


namespace SecondMoshExercises.CodingWithMoshExercises
{
    public class SecondExercise

    {    /// <summary>
         /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         /// Display the result on the console.
         /// </summary>
        public void Exercise1()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                }
            };
        }

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {

                Console.Write("Please enter a number or type 'ok' to exit: ");
                var input = Console.ReadLine();


                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);


            }
            Console.WriteLine($"The sum of the numbers are {sum}");
        }


        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>

        public void Exercise3()
        {
            // Console.Write("Please enter a number: ");
            // var number = Convert.ToInt32(Console.ReadLine());
            // for (int i = number; i >= 1; i--)
            // {
            //     System.Console.WriteLine($"{number} {i} ");
            // }


            Console.Write("Enter a number: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            var number = 5;

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine($"The factorial of {number} is {factorial}");
        }

        ///<summary>
        //Write a program that picks a random number between 1 and 10. 
        //Give the user 4 chances to guess the number. 
        //If the user guesses the number, display “You won"; otherwise, 
        //display “You lost". (To make sure the program is behaving 
        //correctly, you can display the secret number 
        //on the console first.)
        ///</summary>

        public void Exercise4()
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine($"The Screct number is {number}");


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the random number ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You've won");
                    return;
                }



            }
            Console.WriteLine("You loose");

        }

        //<summary>
        //Write a program and ask the user to enter a series of numbers separated by comma. 
        //Find the maximum of the numbers and display it on the console. 
        //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        // </summary>

        public void Exercise5()
        {

            Console.WriteLine("Please enter comma seperated numbers");
            string input = Console.ReadLine();

            var numbers = input.Split(',');


            Console.WriteLine(Convert.ToInt32(numbers.Max()));


        }

    }


}



