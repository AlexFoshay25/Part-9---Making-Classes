using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    internal class Student : IComparable<Student>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        private static Random generator = new Random();
        private string firstName;
        private string lastName;
        private int studentNum;
        private string email;
        public Student(string firstName, string lastName)
        {
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            studentNum = generator.Next(999) + 392000;
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
                GenerateEmail();
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
                GenerateEmail();
            }
        }

        public int StudentNumber
        {
            get
            {
                return studentNum;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }


        public void ResetStudentNumber()
        {
            this.studentNum = generator.Next(999) + 392000;
            GenerateEmail();
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;   //Student comparison
            if (student == null)
                return false;
            return this.FirstName == student.FirstName && this.LastName == student.LastName && this.StudentNumber == student.StudentNumber;
        }


        public int CompareTo(Student that)
        {
            if (this.LastName.CompareTo(that.LastName) == 0) //If last names are = , compare the first names
                return this.StudentNumber.CompareTo(that.StudentNumber);

            return this.LastName.CompareTo(that.LastName);  //compare the last names
        }

        private void GenerateEmail()
        {
            string firstThree, lastThree;

            if (firstName.Length <= 3)
            {
                firstThree = firstName.ToLower();
            }
            else
            {
                firstThree = firstName.Substring(0, 3).ToLower();
            }

            if (lastName.Length <= 3)
            {
                lastThree = lastName.ToLower();
            }
            else
            {
                lastThree = lastName.Substring(0, 3).ToLower();
            }


            email = firstThree + lastThree + (StudentNumber + "").Substring(3) + "@ICS4U1.com";


        }

    }





}
