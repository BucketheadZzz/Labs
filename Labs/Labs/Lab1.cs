using System;

namespace Labs
{
    //Waiting for correct input, exceptions/edge cases are not handled :)
    public class Lab1
    {
        public void TaskOne()
        {
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight");
            var weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Concatenation. First name: " + firstName + " Last name: " + lastName + " Age:" + age + " Height:" + height + " Weight:" + weight);
            Console.WriteLine("Formatting. First name: {0} Last name: {1} Age: {2} Height: {3} Weight: {4}", firstName, lastName, age, height, weight);
            Console.WriteLine($"String interpolation. First name: {firstName} Last name: {lastName} Age: {age} Height: {height} Weight: {weight}");
        }


        public void TaskTwo()
        {
            Console.WriteLine("Enter your height");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight");
            var weight = Convert.ToDouble(Console.ReadLine());

            var result = weight / (height * height);

            Console.WriteLine($"BMI: {result}");
        }

        public void TaskThree()
        {
            Console.WriteLine("Enter x1");
            var x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y1");
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter x2");
            var x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y2");
            var y2 = Convert.ToDouble(Console.ReadLine());

            var result = DistanceBetweenTwoPoints(x1, y1, x2, y2);

            Console.WriteLine($"The distance between 2 points: {result:f2}");
        }


        private double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        public void TaskFour()
        {
            var a = 1;
            var b = 2;

            Console.WriteLine($"Before swap 1. a = {a}, b = {b}");

            var c = a;
            a = b;
            b = c;

            Console.WriteLine($"After swap 1. a = {a}, b = {b}");

            a = 1;
            b = 2;

            Console.WriteLine($"Before swap 2. a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swap 1. a = {a}, b = {b}");
        }
    }
}
