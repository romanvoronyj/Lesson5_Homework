using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Відобразимо прямокутник:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("*");
                }

                // Перехід на новий рядок.
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int c = 0; c < 5;c++)//трикутник П1
            {
                for(int d = 5; d > c ; d--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int e = 0; e < 5; e++)//трикутник П2
            {
                for(int f=0; f<=e; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int g = 0;  g <= 5; g++)//трикутник П3
            {
                for (int d = 5; d > g; d--)
                {
                    Console.Write(" ");
                }
                for (int m = 0; m < g; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < 5; j++)//трикутник П4
            {
                for (int f = 0; f < j; f++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > j; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int h = 6;



            Console.ReadKey();
        }
    }
}
