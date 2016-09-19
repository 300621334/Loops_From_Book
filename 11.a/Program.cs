using System;
/*11. a. Write a console-based program that asks a user for a business
name. Suggest a good Web address by adding “www.”
to the front of the name, removing all spaces from the name,
and adding “.com” to the end of the name. For example,
a good Web address for “Acme Plumbing and Supply”
is www.AcmePlumbingandSupply.com.*/

namespace _11.a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine(); ;
            Console.Write("A good name for your website would be : www.");
            for (int num=0;num<name.Length;num++)
            {
                string letter = name.Substring(num, 1);
                if (letter!=" ")
                {
                    Console.Write("{0}", letter);
                }
            }
            Console.Write(".com");
            Console.WriteLine();
        }
    }
}
