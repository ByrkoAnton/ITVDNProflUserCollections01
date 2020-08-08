using System;
using System.Collections;
using System.ComponentModel;

namespace UserCollections03
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection persons = new PersonCollection();
            int n = int.Parse(persons.Add(new Student("Anton", "Byrko", 1234, "ITVDN")));// играюсь метод возврвщает место в очереди. 
            persons.Add(new Student("Anton2", "Byrko2", 12345, "ITVDN"));
            persons.Add(new Student("Anton3", "Byrko3", 1233, "ITVDN"));
            persons.Add(new Retiree("Ivan", "Ivanov", 546, 80));
            persons.Add(new Worker("Vova", "Sidorov", 34356, "NP", 80000));
            persons.Dell(new Student("Anton3", "Byrko3", 1233, "ITVDN"));
            foreach (Person i in persons)
            {
                Console.WriteLine(i.Show());
                Console.WriteLine();
            }

           var isCont = persons.Contains(new Student("Anton", "Byrko", 1234, "Itvdn"));
           foreach (var i in isCont)
           {
               Console.Write(i +" ");
           }

           Console.WriteLine("\n\nreturn last");
           var lasPerson = persons.ReturnLast();

           var last = lasPerson[0] as Person;
           Console.WriteLine(last.Show());

           int lasIndex = lasPerson[1] is int ? (int) lasPerson[1] : 0;
           Console.WriteLine(lasIndex);


           persons.Clear();
        }
    }
}
