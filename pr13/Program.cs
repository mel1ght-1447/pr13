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
        static int Powerfive(int n, int power1 = 0)
        {
            if (n <= 0)
                return -1;
            if (n == 1)
                return power1;
            if (n % 5 != 0)
                return -1;
            return Powerfive(n / 5, power1 + 1);
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №13";
            bool repeat = true; // ввод переменной
            while (repeat)
            {
                Console.WriteLine("Здравствуйте!");
                try
                {
                    Console.Write("Введите число: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int power = Powerfive(n);
                    if (power >= 0)
                    {
                        Console.WriteLine($"Число {n} является {power} степенью числа 5");
                    }
                    else
                        Console.WriteLine($"Число {n} не является степенью числа 5");

                }
                catch (Exception ex) // обработка исключений
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("Нажмите Y - выход из консоли, N - повтор");
                string selectKey = Console.ReadLine();
                Console.WriteLine();
                switch (selectKey)
                {
                    case "N":// продолжается цикл
                        Console.Clear();
                        repeat = true;
                        break;
                    case "Y": // выход из цикла
                        repeat = false;
                        Environment.Exit(0);
                        break;
                    default: // при любом другом
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введена неправильная буква");
                        Console.ForegroundColor = ConsoleColor.White;
                        repeat = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
