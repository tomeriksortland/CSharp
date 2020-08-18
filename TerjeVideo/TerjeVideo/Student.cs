using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace TerjeVideo
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Student( string firstName)
        {
            FirstName = firstName;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void RenameFirstName()
        {
            FirstName = "Per";
        }
    }
}
