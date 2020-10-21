using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите расстояние между рядами (см): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние между дырочками в ряду (см): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество дырочек на ряд: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длинну свободного конца шнурка (см): ");
            int d = Convert.ToInt32(Console.ReadLine());
            int length = (d * 2 + (c - 1) * 2 * (a + b) + a);
            Console.WriteLine("Длина шнурка вашего ботинка: " + length + " см");
            Console.ReadKey();
        }
    }
}
