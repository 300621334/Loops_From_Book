using System;
/*7. a. Write a console-based application that displays every
integer value from 1 to 20, along with its squared value.*/

namespace _07.a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number - Square\n====== - ======");
            for (int num=1;num<=20;num++)
            {
                double square = Math.Pow(num, 2);
                Console.WriteLine("{0, 4}         {1}",num, square);
            }
        }
    }
}
