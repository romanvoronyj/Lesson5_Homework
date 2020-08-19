using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість клієнтів Вашої компанії:");
            int n = int.Parse(Console.ReadLine());
            int cargo = 1;
            do
            {
                cargo*= n--;
            }
            while (n > 0);
            Console.Write("Існує можливих {0} варіантів маршрутів", cargo);
            Console.ReadKey();

        }
    }
}
