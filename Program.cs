using System;

namespace Taskstruct
{
    struct Task
    {
        public bool done;
        public string title;
        public DateTime duedate;
        public string description;
        public string id;
    }
    class Program
    {
        static void ConsoleOut(Task task)
        {
            char done;
            if (task.done == true)
            {
                done = 'x';
            }
            else
            {
                done = ' ';
            }

            Console.WriteLine($" {task.id} [{done}] {task.title} ({task.duedate.ToString("MMMM dd")})\n    {task.description}");
        }
        static void Main(string[] args)
        {
            Task task = new Task(){id = "1.",
            duedate = DateTime.Today,
            done = true,
            title = "Implement task output",
            description = "Use fields: title, desc, done, dueDate"};
            ConsoleOut(task);
            Task task2 = new Task(){id = "2.",
            duedate = DateTime.Today,
            done = false,
            title = "Implement task output",
            description = "Use fields: title, desc, done, dueDate"};
           ConsoleOut(task2);

        }
    }
}

