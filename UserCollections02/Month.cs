using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace UserCollections02
{
    class Month
    {
        public int N { get; }
        public string Name { get; }
        public int DaysInMonth { get; }

        public Month(int n, string name, int daysInMonth)
        {
            N = n;
            Name = name;
            DaysInMonth = daysInMonth;
        }

        public void Show()
        {
            Console.WriteLine($"№{N}) {Name} {DaysInMonth}");
            
        }
    }
}
