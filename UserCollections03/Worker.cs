using System;
using System.Collections.Generic;
using System.Text;

namespace UserCollections03
{
    class Worker:Person
    {
        public string Company { get; }
        public int Salary { get; }
        
        public Worker(string firstName, string lastName, int pasport, string company, int salary) : base(firstName, lastName,  pasport)
        {
            Company = company;
            Salary = salary;
        }

        public override string Show()
        {
            return base.Show()+$"\nCompany {Company}\nSalary {Salary}";
        }
    }
}
