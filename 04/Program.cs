using System;
/*Three salespeople work at Sunshine Hot Tubs—Andrea,
Brittany, and Eric. Write a console-based application that
prompts the user for a salesperson’s initial (‘A’, ‘B’, or ‘E’).
While the user does not type ‘Z’, continue by prompting for
the amount of a sale the salesperson made. Calculate the
salesperson’s commission as 10% of the sale amount, and add
the commission to a running total for that salesperson. After
the user types ‘Z’ for an initial, display each salesperson’s total
commission earned.*/

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial, initialCap;
            char initialChar=' ';
            double commA=0, commB=0, commE = 0, sale=0;
            
            for(;initialChar!='Z';)
            {
                Console.Write("Enter salesperson's initial 'A' ,'B' or'E' (or 'Z' to exit):");
                initial = Console.ReadLine();
                initialCap = initial.ToUpper();
                initialChar = Convert.ToChar(initialCap);

                if (initialChar=='A')
                {
                    Console.Write("Enter sales for person \"A\": ");
                    sale = Convert.ToInt32(Console.ReadLine());
                    commA += (sale * 0.1);
                }
                else 
                if(initialChar == 'B')
                {
                    Console.Write("Enter sales for person \"B\": ");
                    sale = Convert.ToInt32(Console.ReadLine());
                    commB += (sale * 0.1);
                }

                else 
                if (initialChar == 'E')
                {
                    Console.Write("Enter sales for person \"E\": ");
                    sale = Convert.ToInt32(Console.ReadLine());
                    commE += (sale * 0.1);
                }
            }
            Console.WriteLine("Total commission for A:{0}, B:{1}, E:{2}",commA, commB, commE);





        }
    }
}
