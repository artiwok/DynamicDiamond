using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // DynamicDiamond
            //   *
            //  ***
            // *****
            //  ***
            //   *    

            Console.Write("Enter height: ");

            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 1; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }

                for (int j = 1; j < height - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
