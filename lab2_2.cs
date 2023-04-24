using System;

namespace SmallestNumberWithGivenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number X: ");
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint x))
            {
                Console.WriteLine("Invalid input. Please enter a natural number.");
                return;
            }

            if (x == 0)
            {
                Console.WriteLine("The product of the digits of 0 is 0, so the smallest number with this product is 10.");
                return;
            }

            if (x == 1)
            {
                Console.WriteLine("The product of the digits of 1 is 1, so the smallest number with this product is 1.");
                return;
            }

            uint n = 0;

            for (uint i = 9; i >= 2; i--)
            {
                while (x % i == 0)
                {
                    x /= i;
                    n = n * 10 + i;
                }
            }

            if (x > 1)
            {
                Console.WriteLine("There is no natural number whose product of digits is {0}.", input);
            }
            else
            {
                uint smallestNumber = 0;

                while (n > 0)
                {
                    smallestNumber = smallestNumber * 10 + n % 10;
                    n /= 10;
                }

                Console.WriteLine("The smallest natural number whose product of digits is {0} is {1}.", input, smallestNumber);
            }
        }
    }
}

