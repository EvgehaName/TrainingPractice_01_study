using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            do
            {
                Console.Write("Введите слово exit для завершения программы (Программа закроется): ");
                word = Console.ReadLine();
                
            } while (word != "exit"); // Граница завершения программы ! 
        }
    }
}
