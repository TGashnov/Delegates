using System;
using System.Collections.Generic;

namespace Task2._1
{
    class Program
    {
        static string message = "Сколько литров вы хотите ";

        static void Main(string[] args)
        {
            Tank tank = new Tank(MaxVolume());
            Menu menu = new Menu(new List<MenuItem>()
            {
                new MenuItem(ConsoleKey.F1, "Долить", () => Add(tank)),
                new MenuItem(ConsoleKey.F2, "Слить", () => Take(tank))
            });
            while (true)
            {
                Console.Clear();
                menu.Print();
                Console.WriteLine("Заполнено {0} л из {1} л", tank.CurrentVolume, tank.MaxVolume);
                ConsoleKey key = Console.ReadKey().Key;
                menu.Action(key);                
            }
        }

        static int MaxVolume()
        {
            InputValidation("Введите максимальный объем", out int maxVolume);
            return maxVolume;
        }

        static void Add(Tank tank)
        {
            InputValidation(message + "долить", out int volume);
            try
            {
                tank.Add(volume);
            }
            catch (TankOverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        static void Take(Tank tank)
        {
            InputValidation(message + "слить", out int volume);
            try
            {
                tank.Take(volume);
            }
            catch (NotEnoughException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        static void InputValidation(string message, out int volume)
        {
            Console.Clear();
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out volume) || volume < 0)
            {
                Console.WriteLine("Вы ввели некорректные данные. Попробуйте еще раз");
            }
        }
    }
}
