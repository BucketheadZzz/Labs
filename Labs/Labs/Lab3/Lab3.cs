using System;
using System.Collections.Generic;

namespace Labs.Lab3
{
    public class Lab3
    {
        /*
         * 2.
           а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
         */
        public void TaskTwo()
        {
            Console.Write("Enter numbers: ");
            var oddDigitsSum = 0;
            var listOfOddDigits = new List<int>();
            while (true)
            {
                var enteredNumber = Console.ReadLine();
                if (int.TryParse(enteredNumber, out var parsedValue))
                {
                    if (parsedValue == 0)
                    {
                        break;
                    }

                    if (parsedValue > 0 && parsedValue % 2 != 0)
                    {
                        listOfOddDigits.Add(parsedValue);
                        oddDigitsSum += parsedValue;
                    }
                }
            }

            Console.WriteLine($"The odd digits: {string.Join(' ', listOfOddDigits)}");
            Console.WriteLine($"The sum of odd digits: {oddDigitsSum}");
        }


        /* 
        3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
           Добавить свойства типа int для доступа к числителю и знаменателю;
           Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); *** Добавить упрощение дробей.
        */
        public void TaskThree()
        {
            var fractionA = new Fraction(12, 144);
            var fractionB = new Fraction(1, 12);
            Console.WriteLine($"Decimal value: {fractionA.DecimalFractionValue}");

            Fraction.Add(fractionA, fractionB);
            Console.WriteLine($"Add operation result: {fractionA.DecimalFractionValue}");

            var subtractionA = new Fraction(4, 5);
            var subtractionB = new Fraction(3, 5);
            Fraction.Subtraction(subtractionA, subtractionB);
            Console.WriteLine($"Subtraction operation result: {subtractionA.DecimalFractionValue}");


            var multiplicationA = new Fraction(2, 5);
            var multiplicationB = new Fraction(3, 4);
            Fraction.Multiply(multiplicationA, multiplicationB);
            Console.WriteLine($"Multiply operation result: {multiplicationA.DecimalFractionValue}");


            var divideA = new Fraction(4, 7);
            var divideB = new Fraction(2, 5);
            Fraction.Divide(divideA, divideB);
            Console.WriteLine($"Divide operation result: {divideA.DecimalFractionValue}");


            var fractionToSimplify = new Fraction(12, 144);
            Fraction.Simplify(fractionToSimplify);


            Console.WriteLine($"After simplification: {fractionToSimplify.Numerator}/{fractionToSimplify.Denominator}");

            //A creepy try/catch in order to show that the 0-denominator is handled
            try
            {
                new Fraction(10, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
