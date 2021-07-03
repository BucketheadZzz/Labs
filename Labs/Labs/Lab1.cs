using System;

namespace Labs
{
    //Waiting for correct input, exceptions/edge cases are not handled :)
    public class Lab1
    {

        /*
         *1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
           а) используя склеивание;
           б) используя форматированный вывод;
           в) используя вывод со знаком $.
         */
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

        /*
         * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
         */
        public void TaskTwo()
        {
            Console.WriteLine("Enter your height");
            var height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight");
            var weight = Convert.ToDouble(Console.ReadLine());

            var result = weight / (height * height);

            Console.WriteLine($"BMI: {result}");
        }

        /*
         * 3. 
           а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
           б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
         */
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

        /*
           4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
           а) с использованием третьей переменной;
           б) *без использования третьей переменной.
        */
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
