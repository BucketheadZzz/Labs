using System;
using System.Collections.Generic;

namespace Labs
{
    public static class LabRunner
    {
        private static readonly Lab1 lab1 = new Lab1();
        private static readonly Lab2 lab2 = new Lab2();
        private static readonly Lab3.Lab3 lab3 = new Lab3.Lab3();
        private static readonly Lab4 lab4 = new Lab4();
        private static readonly Lab5.Lab5 lab5 = new Lab5.Lab5();
        private static readonly Lab7 lab7 = new Lab7();

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

            {"3-2", lab3.TaskTwo},
            {"3-3", lab3.TaskThree},

            {"4-1", lab4.TaskOne},
            {"4-2", lab4.TaskTwo},
            {"4-3", lab4.TaskThree},

            {"5-1", lab5.TaskOne},
            {"5-2", lab5.TaskTwo},
            {"5-3", lab5.TaskThree},

            {"7-1", lab7.TaskOne},
            {"7-2", lab7.TaskTwo}

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
