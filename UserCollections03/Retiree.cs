using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollections03
{
    class Retiree:Person
    {
        public int Age { get; }
        public Retiree(string firstName, string lastName, int pasport, int age) : base(firstName, lastName, pasport)
        {
            Age = age;
        }

        public override string Show()
        {
            return base.Show()+$"\nAge {Age}";
        }
    }
}
