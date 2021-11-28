// See https://aka.ms/new-console-template for more information
using System;
namespace DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            // Initiate an array of 10 length.
            int[] a = new int[10];
            // Ask user for a number to convert to Binary - convert str to int.
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            /* for loop until n is greater than 0. Within the loop calculate modulas on n and return the remaining
            to the array. Then calculate n divided by 2 and save it to n. */
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number = ");
            // for loop to reverse print array.
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}


// power of 2 numbers - 2 4 8 16 32 64 128 
// if user selected 5 would mean 5/2 = 2.5 (1 remaining in modulus cal so 1 adds to array) n becomes 2
// 2 / 2 = 1 with 0 remaining and this is added to array 0 n becomes 1. arr( 10)
// 1 / 2 = 0.5 with 1 remaining added to array and n becomes 0. loop now stops due to n no longer being bigger than 0.
// arr becomes (1 0 1)
