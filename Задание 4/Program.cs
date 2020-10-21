using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество ящиков: ");
            int box = Convert.ToInt32(Console.ReadLine());
            int container;
            int car;
            int b = 1;
            int c = 1;

            if (box % 27 == 0)
            {
                container = box / 27;
            }
            else
            {
                container = box / 27 + 1;
            }

            if (container % 12 == 0)
            {
                car = container / 12 + 1;
            }
            else
            {
                car = container / 12 + 1;
            }

            for (int i = 1; i <= car; i++)
            {
                Console.WriteLine("Грузовик: " + i);
                int j = 0;
                while (j < 12 && c <= container)
                {
                    Console.WriteLine("\tКонтейнер: " + c);
                    int k = 0;
                    while (k < 27 && b <= box)
                    {
                        Console.WriteLine("\tЯщик: " + b);
                        k++;
                        b++;
                    }
                    j++;
                    c++;
                }
                Console.ReadKey();
            }
        }
    }
}
