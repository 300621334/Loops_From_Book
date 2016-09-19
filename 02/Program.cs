using System;
/*Write a console-based application that asks the user to type a
vowel from the keyboard. If the character entered is a vowel,
display “OK”; if it is not a vowel, display an error message.*/

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            char  let=' ';
            Console.Write("Enter a vowel: ");
            let = Convert.ToChar(Console.ReadLine());
            for (; let != '!';)
            {
               
                if (let == 'a' || let == 'e' || let == 'i' || let == 'o' || let == 'u')
                {
                    Console.WriteLine("OK");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    break;

                }

            }
        }
    }
}
