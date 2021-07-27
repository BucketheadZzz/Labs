namespace Labs.Lab6
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Department { get; set; }
        public int Group { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }

    }
}
