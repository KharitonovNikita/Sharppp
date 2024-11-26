using System;
using System.Collections.Generic;

namespace ToDoApp
{

    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Task(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class ToDoList
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string taskName)
        {
            int taskId = tasks.Count + 1;
            tasks.Add(new Task(taskId, taskName));
            Console.WriteLine($"Задача '{taskName}' добавлена.");
        }   

        public void RemoveTaskID(int taskId)
        {
            var task = tasks.Find(t => t.Id == taskId);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine($"Задача '{task.Name}' удалена.");
            }
            else
            {
                Console.WriteLine("Задача не найдена.");
            }
        }

        public void RemoveTaskName(string taskName)
        {
            var task = tasks.Find(t => t.Name.Equals(taskName, StringComparison.OrdinalIgnoreCase));
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine($"Задача '{task.Name}' удалена.");
            }
            else
            {
                Console.WriteLine("Задача с таким названием не найдена.");
            }
        }






        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Нет данной задачи.");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"ID: {task.Id} - {task.Name}");
                }
            }
        }
    }

    
}