using System;

namespace Labs
{
    public class Lab2
    {
        //1. Написать метод, возвращающий минимальное из трёх чисел.
        public void TaskOne()
        {
            Console.Write("Enter the first number: ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            var c = Convert.ToDouble(Console.ReadLine());

            var minNumber = GetMinNumber(a, b, c);
            Console.WriteLine($"The minimum is {minNumber}");
        }

        private double GetMinNumber(double a, double b, double c)
        {

            if (a <= b && a < c)
            {
                return a;
            }

            if (b <= a && b <= c)
            {
                return b;
            }

            return c;
        }

        //2. Написать метод подсчета количества цифр числа.
        public void TaskTwo()
        {
            Console.Write("Enter the number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var numberOfDigits = CountNumberOfDigits(number);
            Console.WriteLine($"The answer is {numberOfDigits}");
        }

        private int CountNumberOfDigits(int number)
        {
            var count = 0;

            while (number != 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        public void TaskThree()
        {
            Console.Write("Enter numbers: ");
            var oddDigitsCount = 0;
            while (true)
            {
                var number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }

                if (number > 0 && number % 2 != 0)
                {
                    oddDigitsCount++;
                }
            }

            Console.WriteLine($"The number of odd digits: {oddDigitsCount}");
        }

        /*
         *4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            С помощью цикла do while ограничить ввод пароля тремя попытками.
         */
        public void TaskFour()
        {
            const int maxAttempts = 3;
          

            var currentAttemptsCount = 0;
            var loginSuccess = false;
            do
            {
                Console.Write("Enter login: ");
                var login = Console.ReadLine();

                Console.Write("Enter password: ");
                var password = Console.ReadLine();

                if (!CheckCreds(login, password))
                {
                    currentAttemptsCount++;
                    Console.WriteLine(
                        $"Incorrect password. Try again. Attempts left: {maxAttempts - currentAttemptsCount} ");
                }
                else
                {
                    loginSuccess = true;
                }

            } while (!loginSuccess && currentAttemptsCount < maxAttempts);

            Console.WriteLine(loginSuccess ? "Successful login" : "Your account is blocked");
        }

        private bool CheckCreds(string login, string password)
        {
            const string defaultLogin = "root";
            const string defaultPassword = "GeekBrains";

            return !(login != defaultLogin || password != defaultPassword);
        }

        /*
         *6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            «Хорошим» называется число, которое делится на сумму своих цифр. 
            Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         */
        public void TaskSix()
        {
            const long numberLimit = 1000000000;
            var numbersCount = 0;
            var startTime = DateTime.Now;
            for (var i = 1; i <= numberLimit; i++)
            {
                var digitsSum = GetDigitsSum(i);
                if (i % digitsSum == 0)
                {
                    numbersCount++;
                }
            }

            var timeSpent = (DateTime.Now - startTime).TotalSeconds;

            Console.WriteLine($"The amount of 'good' number: {numbersCount}. Time spent: {timeSpent:f2} seconds");
        }

        private long GetDigitsSum(long number)
        {
            long sum = 0;
            
            while (number != 0)
            {
                var digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }

        /*
         * 7.
           a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
           б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         */
        public void TaskSeven()
        {
            Console.Write("Enter range start number: ");
            var startNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter range end number: ");
            var endNumber = Convert.ToInt32(Console.ReadLine());

            if (startNumber >= endNumber)
            {
                Console.Write("Incorrect range");
                return;
            }

            //a
            WriteFullRange(startNumber, endNumber);
            Console.WriteLine();

            //b
            var sum = GetRangeSum(startNumber, endNumber, 0);
            Console.WriteLine($"The sum of the range: {sum}");
        }

        private void WriteFullRange(int start, int end)
        {
            if (start == end)
            {
                Console.Write(end);
                return;
            }

            Console.Write(start);

            WriteFullRange(start + 1, end);
        }

        private int GetRangeSum(int start, int end, int subSum)
        {
            if (start == end)
            {
                return subSum + end;
            }

            subSum += start;
            return GetRangeSum(start + 1, end, subSum);
        }
    }
}
