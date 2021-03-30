using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string lastName;



            List<Student> students = new List<Student>();

            students.Add(new Student("Alex", "Foshay"));
            students.Add(new Student("Evan", "Gurtz"));
            students.Add(new Student("John", "Doe"));





            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            do
            {
                Console.WriteLine("Enter the first name of a student you want to add.");
                firstName = Console.ReadLine();

                Console.WriteLine("Enter the last name of the student you want to add.");
                lastName = Console.ReadLine();

                students.Add(new Student(firstName, lastName));

            } while (students.Count < 5);


            foreach (Student student in students)
            {
                Console.WriteLine(student.StudentNumber + " " + student.Email);

            }

            students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}