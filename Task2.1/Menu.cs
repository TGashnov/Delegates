using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1
{
    public class Menu
    {
        public IEnumerable<MenuItem> Items { get; }

        public Menu(IEnumerable<MenuItem> items)
        {
            Items = items;
        }

        public void Print()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            foreach(var item in Items)
            {
                item.Print();
                Console.Write("    ");
            }
            Console.Write(new string(' ', Console.WindowWidth - Console.CursorLeft));
            Console.ResetColor();
        }

        public bool Action(ConsoleKey key)
        {
            foreach(var item in Items)
            {
                if (item.Key == key)
                {
                    item.Action();
                }
            }
            return true;
        }
    }

    public class MenuItem
    {
        public ConsoleKey Key { get; }
        public string Label { get; }
        public Action Action { get; }

        public MenuItem(ConsoleKey key, string label, Action action)
        {
            Key = key;
            Label = label;
            Action = action;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Key);
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Label);
        }
    }
}
