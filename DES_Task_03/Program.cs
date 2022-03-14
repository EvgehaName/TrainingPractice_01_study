using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Привет Мир !";
            string password = "Hello";
            string enterPassword;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль: ");
                enterPassword = Console.ReadLine();
                if (enterPassword == password)
                {
                    Console.WriteLine(message);
                    Console.ReadKey();
                    break;
                }
            }            
        }
    }
}
