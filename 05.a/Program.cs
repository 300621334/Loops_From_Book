using System;
/*5. a. Write a console-based application that displays a
multiplication table of the product of every integer from
1 through 10 multiplied by every integer from 1 through 10.*/

namespace _05.a
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row=1;row<=10;row++)
            {
                for(int col=1;col<=10;col++)
                {
                    int multiple = row * col;
                    Console.Write("{0, 3}*{1, 3} = {2, 3}   ", row, col, multiple);
                }
                Console.WriteLine();
            }
            
        }
    }
}
