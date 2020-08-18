using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1__familietre
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Mother;
        public Person Father;

        public string GetDescription()
        {
            string tempStorage = null;
            if (FirstName != null) tempStorage += FirstName + " ";
            if (LastName != null) tempStorage += LastName + " ";
            if (Id != 0) tempStorage += $"(Id={Id}) ";
            if (BirthYear != 0) tempStorage += $"Født: {BirthYear} ";
            if (DeathYear != 0) tempStorage += $"Død: {DeathYear} ";
            if (Father != null)
            {
                if (Father.FirstName != null) tempStorage += $"Far: {Father.FirstName}" + " ";
                if (Father.Id != 0) tempStorage += $"(Id={Father.Id}) ";
            }

            if (Mother != null)
            {
                if (Mother.FirstName != null) tempStorage += $"Mor: {Mother.FirstName}" + " ";
                if (Mother.Id != 0) tempStorage += $"(Id={Mother.Id})";
            }
            

            return tempStorage + "\n";
        }
    }
}
