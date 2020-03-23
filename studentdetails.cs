using System;

namespace Student_details
{

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return StudentId + " " + Name + " " + Address;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student() { StudentId = 1, Name = "Ritu", Address = "Ahmedabad" };
            Console.WriteLine(student);
            Console.ReadLine();
        }
    }
}
