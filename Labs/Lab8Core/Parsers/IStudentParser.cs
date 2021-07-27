using System.Collections.Generic;

namespace Lab8Core.Parsers
{
    public interface IStudentParser
    {
        IList<Student> LoadStudents(string filePath);

        void Save(IList<Student> students, string filePath);
    }
}
