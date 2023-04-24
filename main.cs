using System;

namespace GoodsEnumeration
{
    enum Goods
    {
        Shirt, // 0
        Trousers, // 1
        Jacket, // 2
        Dress, // 3
        Shoes, // 4
        Sneakers, // 5
        TV, // 6
        Laptop, // 7
        Phone // 8
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goods enumeration with flags:");
            Console.WriteLine("0 - Shirt");
            Console.WriteLine("1 - Trousers");
            Console.WriteLine("2 - Jacket");
            Console.WriteLine("3 - Dress");
            Console.WriteLine("4 - Shoes");
            Console.WriteLine("5 - Sneakers");
            Console.WriteLine("6 - TV");
            Console.WriteLine("7 - Laptop");
            Console.WriteLine("8 - Phone");

            Console.WriteLine();

            Console.Write("Enter a list of goods numbers separated by commas: ");
            string input = Console.ReadLine();

            string[] goodsNumbers = input.Split(',');

            Console.WriteLine();

            Console.WriteLine("Selected goods:");

            foreach (string goodsNumber in goodsNumbers)
            {
                if (Enum.IsDefined(typeof(Goods), Convert.ToInt32(goodsNumber)))
                {
                    Console.WriteLine((Goods)Convert.ToInt32(goodsNumber));
                }
                else
                {
                    Console.WriteLine($"Invalid goods number: {goodsNumber}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Author: mynaliuk");

            Console.WriteLine();

            Console.WriteLine("Clothing:");
            Console.WriteLine($"{Goods.Shirt} ({(int)Goods.Shirt})");
            Console.WriteLine($"{Goods.Trousers} ({(int)Goods.Trousers})");
            Console.WriteLine($"{Goods.Jacket} ({(int)Goods.Jacket})");
            Console.WriteLine($"{Goods.Dress} ({(int)Goods.Dress})");

            Console.WriteLine();

            Console.WriteLine("Footwear:");
            Console.WriteLine($"{Goods.Shoes} ({(int)Goods.Shoes})");
            Console.WriteLine($"{Goods.Sneakers} ({(int)Goods.Sneakers})");

            Console.WriteLine();

            Console.WriteLine("Electronics:");
            Console.WriteLine($"{Goods.TV} ({(int)Goods.TV})");
            Console.WriteLine($"{Goods.Laptop} ({(int)Goods.Laptop})");
            Console.WriteLine($"{Goods.Phone} ({(int)Goods.Phone})");

            Console.ReadKey();
        }
    }
}
