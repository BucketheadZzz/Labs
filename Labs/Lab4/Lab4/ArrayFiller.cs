using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Lab4.Lab4
{
    internal static class ArrayFiller
    {
        private const int DefaultArraySize = 20;

        public static int[] FillArrayWithRandomNumbers(FillSettings param)
        {
            var r = new Random();
            var values = new int[DefaultArraySize];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = r.Next(param.MinNumber, param.MaxNumber);
            }

            return values;
        }


        public static int[] FillArrayFromFile(FillSettings param)
        {
            const string filePath = "Numbers.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file doesn't exist :(");
                return new int[0];
            }

            var fileData = File.ReadLines(filePath);
            const char separator = ';';
            var values = new List<int>();

            foreach (var line in fileData)
            {
                values.AddRange(line.Split(separator).Select(value => int.Parse(value.Trim())));    
            }

            return values.ToArray();
        }

        public static int[] FillArrayWithNumbersByStep(FillSettings param)
        {
            var values = new int[DefaultArraySize];
            var startValue = param.StartValue;
            var step = param.Step;
            var calculatedValue = startValue;
            for (var i = 0; i < values.Length; i++)
            {
                if (i > 0)
                {
                    calculatedValue += step;
                }

                values[i] = calculatedValue;
            }

            return values;
        }
    }
}
