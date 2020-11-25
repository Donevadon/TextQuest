using System.Collections.Generic;
using System.Threading;

namespace TestTextQuest
{
    public static class Player
    {
        public static int Money{get;private set;}
        private static List<Item> inventory{get;set;} = new List<Item>();
        public static void AddMoney(int count)
        {
            System.Console.Clear();
            System.Console.WriteLine("Получено монет: " + count.ToString());
            Money += count;
            Thread.Sleep(1000);
        }

        public static void TakeItem(Item item)
        {
            System.Console.Clear();
            System.Console.WriteLine("Получен предмет: " + item.ToString());
            inventory.Add(item);
            Thread.Sleep(1000);
        }
    }
}