using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoList = new ToDoList();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("To-Do List Application");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Удалить задачу");
                Console.WriteLine("3. Показать список задач");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите необходимый вариант: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Введите задачу: ");
                        string taskName = Console.ReadLine();
                        todoList.AddTask(taskName);
                        break;
                    case "2":
                        Console.Write("Введите ID задачи для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out int taskId))
                        {
                            todoList.RemoveTask(taskId);
                        }
                        else
                        {
                            Console.WriteLine("Данный ID задачи проекта не найден");
                        }
                        break;
                    case "3":
                        todoList.DisplayTasks();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Недопустимый параметр");
                        break;
                }

                Console.WriteLine("\nНажмите Enter, чтобы продолжить");
                Console.ReadLine();
            }
        }
    }
}