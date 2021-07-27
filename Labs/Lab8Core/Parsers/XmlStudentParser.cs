using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lab8Core.Parsers
{
    public class XmlStudentParser: IStudentParser
    {
        public IList<Student> LoadStudents(string filePath)
        {
            using var fStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var xmlFormat = new XmlSerializer(typeof(List<Student>));
            var students = (IList<Student>)xmlFormat.Deserialize(fStream);

            return students;
        }

        public void Save(IList<Student> students, string filePath)
        {
            using var fStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            var xmlFormat = new XmlSerializer(typeof(List<Student>));
            xmlFormat.Serialize(fStream, students);
        }
    }
}
