using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2___3
{
    class Program
    {
        static void Main(string[] args)
        {
            int eat = 40;
            int win = 100;
            int notwin = 50;

           for (int i=0; i<=500; i++)
            {
                int eatsum = eat * 10 * 2;
                int kazsum = (win * 2) - (notwin * 8);
                i = eatsum + kazsum;
                if (i <= 500) Console.WriteLine("Сумма затрат: " + i + " Отпуск оплачивается!");
                else Console.WriteLine("Сумма затрат: " + i + " Отпуск не оплачивается!");

            }
            Console.ReadKey();
        }
    }
}
