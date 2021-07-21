using System;
using System.Collections.Generic;
using System.Linq;

namespace Labs.Lab6
{
    public class Lab6
    {
        public void TaskOne()
        {
            Console.Write("Enter X: ");
            var x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter X Max: ");
            var y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter A: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a*x^2 output: ");
            LabTasks.Table(MathFunctions.Func1, x, y, a);

            Console.WriteLine("===========================");

            Console.WriteLine("a*sin(x) output: ");
            LabTasks.Table(MathFunctions.Func2, x, y, a);
        }

        public void TaskTwo()
        {
            Console.WriteLine("Enter a min range value: ");
            var minRangeValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a max range value: ");
            var maxRangeValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose any function:");
            Console.WriteLine("1: x * x-50*x+10 \n2: x + x + 10 \n3: x * x");
            var funcNumber = Convert.ToInt32(Console.ReadLine());

            var funcList = new List<Func<double, double>>
            {
                MathFunctions.Func3(),
                MathFunctions.Func4(),
                MathFunctions.Func5()
            };

            LabTasks.SaveFunc("data.bin", minRangeValue, maxRangeValue, 0.5, funcList[funcNumber - 1]);

            var data = LabTasks.Load("data.bin", out var min);
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Data: {string.Join(',', data)}");
        }

        public void TaskThree()
        {
            var students = LabTasks.LoadStudents();

            var fiveSixCourseStudentsCount = students.Count(student => student.Course == 5 || student.Course == 6);

            Console.WriteLine($"5-6 years students count: {fiveSixCourseStudentsCount}");

            var frequencyStudentsArray = students.Where(student => student.Age >= 18 && student.Age <= 20).ToList();
            Console.WriteLine($"Students between 18 and 20 years old: {frequencyStudentsArray.Count}");
            foreach (var student in frequencyStudentsArray)
            {
                Console.WriteLine($"First Name: {student.FirstName} Last Name: {student.LastName} Course: {student.Course}");
            }

            var studentsSortedByAge = students.OrderBy(student => student.Age);
            Console.WriteLine("Sorting by age:");
            foreach (var student in studentsSortedByAge)
            {
                Console.WriteLine($"First Name: {student.FirstName} Last Name: {student.LastName} Course: {student.Course} Age: {student.Age}");
            }

            var studentsSortedByCourseAndAge = students.OrderBy(student => student.Course).ThenBy(student => student.Age);
            Console.WriteLine("Sorting by course and age:");
            foreach (var student in studentsSortedByCourseAndAge)
            {
                Console.WriteLine($"First Name: {student.FirstName} Last Name: {student.LastName} Course: {student.Course} Age: {student.Age}");
            }
        }
    }
}
