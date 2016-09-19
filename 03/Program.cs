using System;
/*Write a console-based application that prompts a user for an
hourly pay rate. While the user enters values less than $5.65
or greater than $49.99, continue to prompt the user. Before
the program ends, display the valid pay rate.*/

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 0;
            for(;rate<5.65 || rate>49.99;)
            {
                Console.Write("Enter Pay Rate:");
                rate = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Pay rate is: {0}", rate);
        }
    }
}
