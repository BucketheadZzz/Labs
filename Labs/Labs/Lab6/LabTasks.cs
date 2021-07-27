using System;
using System.Collections.Generic;
using System.IO;
using Lab8Core;

namespace Labs.Lab6
{
    public class LabTasks
    {
        public static void Table(Func<double, double, double> tableFunc, double x, double limit, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= limit)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, tableFunc(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Func<double, double> F)
        {
            using var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            using var bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
        }

        public static double[] Load(string fileName, out double resultMin)
        {
            using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using var bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            var resultList = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                resultList.Add(d);
                if (d < min) min = d;
            }

            resultMin = min;
        
            return resultList.ToArray();
        }


        public static IList<Student> LoadStudents()
        {
            var list = new List<Student>();                        
            using var sr = new StreamReader("Lab6/students.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    var s = sr.ReadLine()?.Split(',');
                    if (s != null)
                    {
                        list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return list;
        }

    }
}
