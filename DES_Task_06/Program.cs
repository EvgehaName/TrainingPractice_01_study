using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Task_06
{
    internal class Program
    {
        static void CountArray(ref string[] nameArray, ref string[] postArray, int size)
        {
            string[] strNameArray = new string[nameArray.Length + size];
            string[] strPostArray = new string[postArray.Length + size];
            for (int i = 0; i < nameArray.Length; i++)
            {
                strNameArray[i] = nameArray[i];
                strPostArray[i] = postArray[i];
            }
            nameArray = strNameArray;
            postArray = strPostArray;
        }
        static void Insert(ref string[] name, ref string[] post, int enterN)
        {
            CountArray(ref name, ref post, enterN);
            for (int i = 0; i < enterN; i++)
            {

                Console.Write("Введите ФИО:");
                name[i] = Console.ReadLine();
                Console.Write("Введите должность:");
                post[i] = Console.ReadLine();
            }
        }
        static void OutArray(string[] name, string[] post)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(i + ") " + name[i] +  " - " + post[i]);
            }
        }
        
        static void Search(string[] name, string[] post)
        {
            int num = 0;
            Console.Write("Введите фамилию для поиска: ");
            string str = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].StartsWith(str))
                {
                    Console.WriteLine(i + "\t" + name[i] + "\t - " + post[i]);
                    num++;
                }
            }
            if (num > 0)
                Console.WriteLine(string.Format("Количество сотрудников с фамилией {0} - {1}", (object)str, (object)num));
            else
                Console.WriteLine("Сотрудников с фамилией " + str + " нет");
        }
        static void DeleteElem(ref string[] name, ref string[] post)
        {
            int enterElem;
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(i + ") " + name[i] + " - " + post[i]);
            }
            Console.WriteLine("Выберите элемент списка: ");
            while (!int.TryParse(Console.ReadLine(), out enterElem) || enterElem > name.Length)
            {
                Console.WriteLine("Вы ввели неправильно !\nПовторите ввод !");
            }
            DelArray(ref name, ref post, enterElem);
        }
        static void DelArray(ref string[] nameArray, ref string[] postArray, int elem)
        {
            string[] strNameArray = new string[nameArray.Length -1];
            string[] strPostArray = new string[postArray.Length -1];
            for (int i = 0; i < elem; i++)
            {
                strNameArray[i] = nameArray[i];
                strPostArray[i] = postArray[i];
            }
            for (int i = elem +1; i < nameArray.Length; i++)
            {
                strNameArray[i - 1] = nameArray[i];
                strPostArray[i - 1] = postArray[i];
            }
            nameArray = strNameArray;
            postArray = strPostArray;
        }
        static void Main(string[] args)
        {
            string[] name = new string[0];
            string[] post = new string[0];
            int numberEnter;
            int exit;
            do
            {
                Console.WriteLine("Информация которая доступна:");
                Console.WriteLine("1) Добавить досье");
                Console.WriteLine("2) Вывести все досье (в одну строку через “-” фио и должность с порядковым номером в начале)");
                Console.WriteLine("3) Удалить досье");
                Console.WriteLine("4) Поиск по фамилии");
                Console.WriteLine("5) Выход из программы");
                while (!int.TryParse(Console.ReadLine(), out numberEnter))
                {
                    Console.WriteLine("Вы неправильно ввели данные !\nПроверьте ввод !");
                }
                if (numberEnter == 1)
                {
                    int enterN;
                    Console.Write("Нужно ввести количество элементов: ");
                    while (!int.TryParse(Console.ReadLine(), out enterN))
                    {
                        Console.WriteLine("Вы ввели неправильно !\nПовторите ввод !");
                    }
                    Insert(ref name, ref post, enterN);
                }
                else if (numberEnter == 2)
                {
                    OutArray(name, post);
                }
                else if (numberEnter == 3)
                {
                    DeleteElem(ref name, ref post);
                    Console.WriteLine("Список после изменение:");
                    OutArray(name, post);
                }
                else if (numberEnter == 4)
                {
                    Search(name, post);
                }
                else if( numberEnter == 5)
                {
                    goto exit;
                }

                Console.WriteLine("Повторить работу программы ? Да) 1 Нет) 0");
                while (!int.TryParse(Console.ReadLine(), out exit))
                {
                    Console.WriteLine("Вы ввели неправильно !\nПовторите ввод !");
                }
            } while (exit == 1);
            exit:

            Console.ReadLine();
        }
    }
}
