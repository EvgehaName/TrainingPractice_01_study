using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int goldEnter;
            int resultTemp;
            Console.Write("Введите какое количество золото у вас есть ?: ");
            
            while (!int.TryParse(Console.ReadLine(), out goldEnter) || goldEnter < 0)
            {
                Console.WriteLine("Вы неправильно ввели значение !");
                Console.Write("Повторите ввод !\nВведите какое количество золото у вас есть ?:");
            }
            while (goldEnter != 0 || goldEnter > 0 )
            {
                while (goldEnter < 0)
                {
                    Console.WriteLine("У вас отрицательное значение !");
                    goto to_Out;
                }
                int priceCrystal = 2;
                resultTemp = goldEnter / priceCrystal;
                Console.WriteLine("Вы имеете право купить кристалы: " + resultTemp + " кристалы по цене " + priceCrystal + " за одну штуку");
                Console.Write("Сколько хотите купить кристалов ?: ");
                int buyCrystal;
                while (!int.TryParse(Console.ReadLine(), out buyCrystal) || buyCrystal < 0 || buyCrystal > resultTemp)
                {
                    Console.WriteLine("Вы неправильно ввели значение ! Проверьте ваш баланс и возможность купить кристалы");
                    Console.Write("Повторите ввод !\nВведите Сколько хотите купить кристалов ?:");
                    continue;
                }
                goldEnter = goldEnter - buyCrystal * priceCrystal;
                Console.WriteLine("Вы купили " + buyCrystal + " кристалов. У вас осталось " + goldEnter + " золота");
                Console.WriteLine("Вы желаете продолжить покупку ? 1) Y(y) 2) N(n): ");
                string exit = Console.ReadLine();
                while (exit == "N" || exit == "n")
                {
                    goto to_Out;
                }
            }
            to_Out:


            
            Console.ReadKey();
        }
    }
}
