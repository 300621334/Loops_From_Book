using System;
/*12. a. Write a console-based program that accepts a phrase
from the user and counts the number of vowels in the
phrase. For this exercise, count both uppercase and lowercase
vowels, but do not consider “y” to be a vowel.*/

namespace _12.a
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Write a phrase:");
            string phrase = (Console.ReadLine()).ToLower();
            for (int num=0;num<phrase.Length;num++)
            {
                string letter = phrase.Substring(num, 1);
                if(letter=="a"|| letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    counter++;
                }
            }
            Console.WriteLine("Total vowels in phrase are: {0}",counter);
        }
    }
}
