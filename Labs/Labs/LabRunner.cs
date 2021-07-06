using System;
using System.Collections.Generic;

namespace Labs
{
    public static class LabRunner
    {
        private static readonly Lab1 lab1 = new Lab1();
        private static readonly Lab2 lab2 = new Lab2();

        private static readonly IDictionary<string, Action> listOfTasks = new Dictionary<string, Action>
        {
            {"1-1", lab1.TaskOne},
            {"1-2", lab1.TaskTwo},
            {"1-3", lab1.TaskThree},
            {"1-4", lab1.TaskFour},

            {"2-1", lab2.TaskOne},
            {"2-2", lab2.TaskTwo},
            {"2-3", lab2.TaskThree},
            {"2-4", lab2.TaskFour},
            {"2-6", lab2.TaskSix},
            {"2-7", lab2.TaskSeven},
        };


        public static void Run()
        {
            Console.Write("Enter lab number: ");
            var labNumber = Console.ReadLine();

            Console.Write("Enter task number: ");
            var taskNumber = Console.ReadLine();

            var key = $"{labNumber}-{taskNumber}";
            if (listOfTasks.ContainsKey(key))
            {
                listOfTasks[key]();
            }
            else
            {
                Console.WriteLine("Something went wrong... :(");
            }

            Console.ReadKey();
        }
    }
}
