using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace UserCollections02
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            months.Add(new Month(1, "Январь", 31));
            months.Add(new Month(2, "Февраль", 29));
            months.Add(new Month(3, "Март", 31));
            months.Add(new Month(4, "Апрель", 30));
            months.Add(new Month(5, "Май", 31));
            months.Add(new Month(6, "Июнь", 30));
            months.Add(new Month(7, "Июль", 31));
            months.Add(new Month(8, "Август", 31));
            months.Add(new Month(9, "Сентябрь", 30));
            months.Add(new Month(10, "Октябрь", 31));
            months.Add(new Month(11, "Ноябрь", 30));
            months.Add(new Month(12, "Декабрь", 31));
            months.Show();

            Console.WriteLine();

            var m = months.GetMonthByN(2);
            m.Show();

            Console.WriteLine();

            var months2 = months.GetMonthByDays(31);

            foreach (Month i in months2)
            {
                i.Show();
            }
            
            


        }
    }
}
