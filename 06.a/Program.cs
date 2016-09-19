using System;
/*6. a. Write a console-based application that displays all
even numbers from 2 to 100, inclusive.*/

namespace _06.a
{
    class Program
    {
        static void Main(string[] args)
        {for(int num=2;num<=100;num++)
            {
                if(num%2==0)
                {
                    Console.WriteLine("{0}", num);
                }
            }
        }
    }
}
