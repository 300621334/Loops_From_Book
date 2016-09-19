using System;
/*Write a console-based application that allows the user to
enter any number of integer values continuously (in any
order) until the user enters 999. Display the sum of the values
entered, not including 999. Save the fi le as Sum.cs.*/

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 0, sum=0;
            for (; num != 999;)
            {
                sum += num;
                Console.Write("Enter integer: ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Sum is {0}",sum);

        }
    }
}
