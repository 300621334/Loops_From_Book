using System;
/*13. a. In the chapter Making Decisions, you created a console based
program that generates a random number, allows a
user to guess it, and displays a message indicating whether
the guess is too low, too high, or correct. Now modify
that program so that the user can continue to enter values 
until the correct guess is made. After the user guesses correctly,
display the number of guesses made.*/

namespace _13.a
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Random ran = new Random();
            int ran1 = ran.Next(1, 3);

            Console.WriteLine("Guess a number from 1 to 2");
            int guess = Convert.ToInt32(Console.ReadLine());

            for(;guess!=ran1;)
            {
                Console.WriteLine("Try again from 1 to 2");
                guess = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            Console.WriteLine("You made {0} guesses and correct guess is {1}",counter, guess);
        }
    }
}
