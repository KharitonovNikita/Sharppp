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
                        Console.WriteLine("Выберите способ удаления задачи:");
                        Console.WriteLine("1. По ID");
                        Console.WriteLine("2. По названию");
                        Console.Write("Введите вариант: ");
                        string deleteOption = Console.ReadLine();

                        if (deleteOption == "1")
                        {
                            Console.Write("Введите ID задачи для удаления: ");
                            if (int.TryParse(Console.ReadLine(), out int taskId))
                            {
                                todoList.RemoveTaskID(taskId);
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ID.");
                            }
                        }
                        else if (deleteOption == "2")
                        {
                            Console.Write("Введите название задачи для удаления: ");
                            string taskToDelete = Console.ReadLine();
                            todoList.RemoveTaskName(taskToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Недопустимый параметр.");
                        }
                        break;

                    case "3":
                        todoList.DisplayTasks();
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Недопустимый параметр.");
                        break;
                }

                Console.WriteLine("\nНажмите Enter, чтобы продолжить.");
                Console.ReadLine();
            }
        }
    }
}