using System.Collections.Generic;
using Lab8Core.Parsers;

namespace Lab8Core
{
    public static class ParsersList
    {
        public static IDictionary<string, IStudentParser> Items = new Dictionary<string, IStudentParser>
        {
            {".xml", new XmlStudentParser()},
            {".csv", new CsvStudentParser()}
        };
    }
}
