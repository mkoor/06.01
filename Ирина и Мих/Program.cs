using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ирина_и_Мих
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в кофейный аппарат FIVE HEARTS!\nПредлагаемые напитки:\nВода - 40\nАмерикано - 100\nЧай - 60\nГорячий шоколад - 70\nМолочный коктейль (клубника) - 100");
            Console.WriteLine("Внесите сумму: ");
            int x = Convert.ToInt32(Console.ReadLine());
                
            if (x < 40) Console.WriteLine("Извините, вы не можете купить напиток! До свидания!");
            else if (x == 40) Console.WriteLine("Вы можете купить воду");
            else if (x <= 60) Console.WriteLine("Вы можете купить воду - 40\nВы можете купить чай");
            else if (x <= 70) Console.WriteLine("Вы можете купить воду - 40\nВы можете купить чай - 60\nВы можете купить горячий шоколад");
            else Console.WriteLine("Вы можете купить воду - 40\nВы можете купить чай - 60\nВы можете купить горячий шоколад -70\nВы можете купить американо - 100\nВы можете купить молочный коктейль - 100");
            
            Console.ReadKey();

        }
    }
}
