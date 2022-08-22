using System;
using ZooLab;
using ZooLab.Animals;

namespace ZooAppConsole
{
    // TODO: Покрыть 100% тестами
    // TODO: Организовать консольный вывод
    // TODO: Полный рефакторинг
    // TODO: Пофиксить все ворнинги
    public class Program
    {
        public static void Main(string[] args)
        {
            ZooApp zooApp = new ZooApp();
            CreateDate.CreateAZoo(zooApp);

            Console.WriteLine("Welcome to ZooLab! You can do next things.\n");
            ZooConsole.ConsoleMain(zooApp);
        }
    }
}

