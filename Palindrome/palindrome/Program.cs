using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int x;
            Console.Write("please enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            
            IsPalindrome(x);
            bool answer = IsPalindrome(x);
            if (answer == true)
            {
                Console.WriteLine($"{x} is Palindrome");
                
            }
            else
            {
                Console.WriteLine($"{x} is not Palindrome");
            }
            Console.ReadLine();
        }
        static bool IsPalindrome(int x)
        {
            bool ispalindrome;
            string b = x.ToString();
            char[] myArray = b.ToCharArray();
            char[] reversedArray = new char[myArray.Length];
            Array.Copy(myArray, reversedArray, myArray.Length);
            Array.Reverse(reversedArray);
            int i;
            for (i = 0; i <= myArray.Length - 1; i++)
            {
                if (myArray[i] != reversedArray[i])
                {
                    return false;
                }
            }
            return true;

            /*if (myArray==reversedArray)
            {
                Console.WriteLine("this number is palindrome.");
                return true;
            }
            Console.WriteLine("this number is not palindrome.");
            return false;*/
        }
    }
}
