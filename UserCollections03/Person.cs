using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserCollections03
{
    abstract class Person
    {
        public string LastName { get; }
        public string FirstName { get; }
        public int Pasport { get; }

        protected Person(string firstName, string lastName, int pasport)
        {
            LastName = lastName;
            FirstName = firstName;
            Pasport = pasport;
        }

        public virtual string Show()
        {
            return $"Last Name {LastName}\nName {FirstName}\nPasport {Pasport}";
        }
    }
}
