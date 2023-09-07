using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_9_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задача 9. Найти общую стоимость покупки*/
            Console.WriteLine("Введите стоимость 1 кг конфет");
            int candies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья");
            int cookies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок");
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу конфет");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу печенья");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите массу яблок");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость покупки:" + (candies * x + cookies * y + apples * z) + "кг");
        }
    }
}
