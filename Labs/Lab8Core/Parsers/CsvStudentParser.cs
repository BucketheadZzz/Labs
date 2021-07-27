using System.Collections.Generic;
using System.IO;

namespace Lab8Core.Parsers
{
    public class CsvStudentParser : IStudentParser
    {
        public IList<Student> LoadStudents(string filePath)
        {
            var list = new List<Student>();
            using var sr = new StreamReader(filePath);
            while (!sr.EndOfStream)
            {
                var studentItem = sr.ReadLine()?.Split(',');
                if (studentItem != null)
                {
                    list.Add(new Student(
                        studentItem[0], 
                        studentItem[1], 
                        studentItem[2], 
                        studentItem[3], 
                        studentItem[4], 
                        int.Parse(studentItem[5]), 
                        int.Parse(studentItem[6]), 
                        int.Parse(studentItem[7]), 
                        studentItem[8]));
                }
            }

            return list;
        }

        public void Save(IList<Student> students, string filePath)
        {
            using var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            using var tw = new StreamWriter(fs);
            foreach (var student in students)
            {
               tw.WriteLine(student);
            }
        }
    }
}
