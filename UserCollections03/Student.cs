using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollections03
{
    class Student:Person
    {
        public string University { get; }
        public Student(string firstName, string lastName, int pasport, string university) : base(firstName, lastName, pasport)
        {
            University = university;
        }

        public override string Show()
        {
            return base.Show()+$"\nUniversity {University}";
        }
    }
}
