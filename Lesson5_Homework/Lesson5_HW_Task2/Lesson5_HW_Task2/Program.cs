using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_HW_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть менше число:");
            string a = Console.ReadLine();
            int op1 = Convert.ToInt32(a);
            Console.WriteLine("Введіть більше число:");
            string b = Console.ReadLine();
            int op2 = Convert.ToInt32(b);
            int summ = 0;

            while (op1 < op2)
            {
                summ += op1++; // сумма всіх значень від меншого (включно) до більшого 
            }
            Console.WriteLine("Сумма значень дорівнює:{0}", summ);

            int neparne =1;
            while (op1&neparne <2)
            {
                op1++; 
                op1 & neparne==1;
            }
            Console.WriteLine(neparne);
            if ((op1++ & neparne) == 1)
            {
                Console.WriteLine("Непарні значення:{0} ", neparne);
            }


            Console.ReadKey();
        }
    }
}
    