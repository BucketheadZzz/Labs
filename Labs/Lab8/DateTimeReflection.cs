using System;

namespace Lab8
{
    public static class DateTimeReflection
    {
        public static void WriteAllProperties()
        {
            foreach (var propertyInfo in new DateTime().GetType().GetProperties())
            {
                Console.WriteLine($"Property name: {propertyInfo.Name}");
            }
        }
    }
}
