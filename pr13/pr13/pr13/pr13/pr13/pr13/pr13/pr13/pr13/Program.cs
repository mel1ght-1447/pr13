//*******************************************
//* Практическая работа №13                 *
//* Выполнил: Быков М.С., группа 2ИСП       *
//* Вариант: 2                              *
//*******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    internal class Program
    {
        static int Powerfive(int n, int power = 0)
        {
            if (n <= 0)
                return -1;
            if (n == 1)
                return power;
            if (n % 5 != 0)
                return -1;
            return Powerfive(n / 5, power + 1);
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №13";
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Здравствуйте!");
                for (int i = 0; i < 1; i++)
                {
                    try
                    {

                        Console.Write("Введите число: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 0 || Powerfive(n) < 0 )
                        {
                            Console.WriteLine($"Число {n} не является степенью числа 5");
                        }
                        else
                        {
                            Console.WriteLine($"Степень: {Powerfive(n)}");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                        i--;
                    }
                }
                Console.WriteLine("Нажмите Y - выход из консоли, N - повтор");
                string selectKey = Console.ReadLine();
                Console.WriteLine();
                switch (selectKey)
                {
                    case "N":
                        Console.Clear();
                        repeat = true;
                        break;
                    case "Y": 
                        repeat = false;
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введена неправильная буква!");
                        Console.ForegroundColor = ConsoleColor.White;
                        repeat = false;
                        break;
                }
            }
        }
    }
}
