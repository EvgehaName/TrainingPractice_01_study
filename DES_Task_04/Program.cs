using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DES_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int helthBoss = 1000;
            int helthPlayer = 600;
            int spellRamashon = 100;
            bool checkRamashon = false;
            int spellHugan = 100;
            int fault = 250;

            int enterSpell;
            int checkBossSpell;

            Random random = new Random();
            int startGame = random.Next(1, 3);
            bool player = false;
            if (startGame == 1)
            {
                Console.WriteLine("Ваш ход !");
                player = true;
            }
            else if (startGame == 2)
            {
                Console.WriteLine("Ход противника !");
                player = false;
            }
            do
            {
                switch (player)
                {
                    case true:
                        Console.WriteLine("Нужно выбрать чем вы будете бить игрока ! ");
                        Console.WriteLine("0) Без использования навыков\n 1) С использованием Рашамон (-100хп)\n 2) С использованием Хуганзакура (-100хп игроку)\n 3) C использованием Межпространственный разлом ");
                        
                        Console.WriteLine("Нужно выбрать вариант: ");
                        while (!int.TryParse(Console.ReadLine(),out enterSpell) || enterSpell == 2 && checkRamashon == false)
                        {
                            Console.WriteLine("Вы неправильно ввели значение !\n либо");
                            Console.WriteLine("У вас не была активирована способность Рамашон. Хуганзакура можно использовать только после применение Рамашона");
                            Console.Write("Нужно выбрать вариант: ");
                        }
                        if (enterSpell == 0)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthBoss = helthBoss - damagePlayer;
                            Console.WriteLine("Ваш игрок нанес " + damagePlayer + " урона противнику");
                        }
                        else if (enterSpell == 1)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthBoss = helthBoss - (damagePlayer + spellRamashon);
                            Console.WriteLine("Ваш игрок нанес " + damagePlayer + " + " + spellRamashon + " урона противнику");
                            checkRamashon = true;
                        }
                        else if (enterSpell == 2 && checkRamashon == true)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthBoss = helthBoss - (damagePlayer + spellHugan);
                            Console.WriteLine("Ваш игрок нанес " + damagePlayer + " + " + spellHugan + " урона противнику");
                        }
                        else if (enterSpell == 3)
                        {
                            //int damagePlayer = random.Next(25, 50);
                            if (helthPlayer < 600)
                            {
                                helthPlayer += 250;
                                Console.WriteLine("Ваш игрок скрылся и противник по вам не попал ! Также добавлено 250ХП к вашему здоровью ");
                            }
                            else if(helthPlayer == 600)
                            {
                                Console.WriteLine("У вас полное ХП, вам не прибавило ХП, но вы скрылись от противника !");
                                Console.WriteLine("Ваше здоровье: " + helthPlayer);
                            }
                            
                        }
                        if (helthBoss < 0)
                        {
                            helthBoss = 0;
                            Console.WriteLine("У противника осталось ХП: " + helthBoss);
                        }
                        else if(helthBoss > 0)
                        {
                            Console.WriteLine("У противника осталось ХП: " + helthBoss);
                        }

                        player = false;
                        break;
                    case false:
                        checkRamashon = false;
                        Console.WriteLine("Ход противника !");
                        Thread.Sleep(3000);
                        checkBossSpell = random.Next(0, 3);
                        if (checkBossSpell == 0)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthPlayer = helthPlayer - damagePlayer;
                            Console.WriteLine("Противник нанес " + damagePlayer + " урона вашему игроку");
                        }
                        else if (checkBossSpell == 1)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthPlayer = helthPlayer - (damagePlayer + spellRamashon);
                            Console.WriteLine("Противник нанес " + damagePlayer + " + " + spellRamashon + " урона вашему игроку");
                            checkRamashon = true;
                        }
                        else if (checkBossSpell == 2 && checkRamashon == true)
                        {
                            int damagePlayer = random.Next(25, 50);
                            helthPlayer = helthPlayer - (damagePlayer + spellHugan);
                            Console.WriteLine("Противник нанес " + damagePlayer + " + " + spellHugan + " урона вашему игроку");
                        }
                        else if (checkBossSpell == 3)
                        {
                            //int damagePlayer = random.Next(25, 50);
                            if (helthBoss < 600)
                            {
                                helthBoss += 250;
                                Console.WriteLine("Противник скрылся и игрок не сможет по вам попасть ! Также добавлено 250ХП противнику здоровья ");
                            }
                            else if (helthBoss == 600)
                            {

                                Console.WriteLine("У противника полное ХП, противник скрылся от вас !");
                                Console.WriteLine("Противника здоровье: " + helthBoss);
                            }

                        }
                        if (helthPlayer < 0)
                        {
                            helthPlayer = 0;
                            Console.WriteLine("У вас осталось ХП: " + helthPlayer);
                        }
                        else if (helthPlayer > 0)
                        {
                            Console.WriteLine("У вас осталось ХП: " + helthPlayer);
                        }

                        player = true;
                        break;
                }
                //while (helthBoss < 0 || helthPlayer < 0)
                //{
                //    goto to_Out;
                //}

            } while (helthBoss != 0 && helthPlayer != 0);
            //to_Out:
            Console.ReadKey();
        }

       

    }
}
