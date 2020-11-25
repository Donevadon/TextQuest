using System;

namespace TestTextQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            ISelectAction selectAction = new ActionSelectSystem(new Road(new RoadAction()));

            while(true)
            {
                
                System.Console.WriteLine(selectAction.Text);
                int index = 0;
                foreach(var action in selectAction)
                {
                    System.Console.WriteLine($"{index++}: {action}");
                }
                try
                {
                    selectAction.Select(int.Parse(Console.ReadKey().KeyChar.ToString()));
                    Console.Clear();
                }catch (FormatException)
                {
                    Console.Clear();
                    System.Console.WriteLine("Необходимо вводить цифры");
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    System.Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
