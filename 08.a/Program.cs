using System;
/*9. a. Write a console-based application that displays every
perfect number from 1 through 1000. A number is perfect
if it equals the sum of all the smaller positive integers that
divide evenly into it. For example, 6 is perfect because
1, 2, and 3 divide evenly into it and their sum is 6.*/

namespace _09.a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int num=1;num<=1000;num++)
            {
                int sum = 0;
                for (int divisor=1; divisor<num;divisor++)
                {
                    if(num%divisor==0)
                    {
                        
                        sum += divisor;
                       
                    }
                }
                if (sum == num)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
