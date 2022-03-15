using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string checkExit;
            do
            {
                Console.Write("Введите количество элементов в массиве: ");
                int numberEnter, rangeNumberEnter;
                while (!int.TryParse(Console.ReadLine(), out numberEnter))
                {
                    Console.WriteLine("Повторите ввод !");
                    Console.Write("Введите количество элементов в массиве: ");
                }
                Console.Write("Введите диапазон генератора чисел от 5 до 1000: ");
                while (!int.TryParse(Console.ReadLine(), out rangeNumberEnter))
                {
                    Console.WriteLine("Повторите ввод !");
                    Console.Write("Введите диапазон генератора чисел от 5 до 1000: ");
                }
                int[] array = new int[numberEnter];
                FillArray(array,rangeNumberEnter);
                Console.WriteLine("Исходный массив");
                OutputArray(array);
                Shuffle(array);
                Console.WriteLine("\nПеремешанный массив");
                OutputArray(array);
                Console.Write("\nВы желаете повторить работу программы ? 1) Y(y) 2) N(n): ");
                checkExit = Console.ReadLine();
            } while (checkExit == "Y" || checkExit == "y" || checkExit == "Д" || checkExit == "д");
        }

        static void FillArray(int[] array, int randomEnter)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, randomEnter);
            }
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int randomItem = random.Next(i);
                int shufflElem = array[randomItem];
                array[randomItem] = array[i];
                array[i] = shufflElem;
            }
        }
    }

}
