using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите что угодно через Enter");
            while(true)
            {
                Check(Input());
            }
        }

        private static List<string> List { get; } = new List<string>();

        private static string Input()
        {
            string input = Console.ReadLine();
            return input;
        }

        private static void Check(string input)
        {
            try
            {
                if (!List.Contains(input.ToLower().Trim()))
                {
                    List.Add(input);
                }
                else
                    throw new AlreadyExistsException(input, List.IndexOf(input));
            }
            catch (AlreadyExistsException e)
            {
                Console.WriteLine($"Элемент {e.Value} уже имеется на {e.Position} позиции!");
            }
        }
    }
}
