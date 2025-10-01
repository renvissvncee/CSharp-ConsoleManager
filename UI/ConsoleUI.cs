using ConsoleManager.Models;
using ConsoleManager.Services;

namespace ConsoleManager.UI;

internal class ConsoleUI
{
    internal static void Run(ToDoManagerService manager)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Создать новый список");
            Console.WriteLine("2. Выбрать список");
            Console.WriteLine("3. Показать все списки");
            Console.WriteLine("0. Выход");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateList(manager);
                    break;
                case "2":
                    SelectList(manager);
                    break;
                case "3":
                    ShowAllLists(manager);
                    break;
                case "0":
                    return;
            }

        }

        private static void CreateList(ToDoManagerService manager)
        {
            Console.Write("Название нового списка: ");
            string title = Console.ReadLine()!;
            var list = new ToDoList { Title = title };
            manager.AddList(list);
            Console.WriteLine($"Список '{title}' создан. Нажмите Enter...");
            Console.ReadLine();
        }

    }
}