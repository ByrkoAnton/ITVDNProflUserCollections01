using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace UserCollections02
{
    class Months : IEnumerable, IEnumerator
    {
        private Month[] months; // сделал что бы была возможность добавить любые месяца и не только 12.

        private int position = -1;

        public IEnumerator GetEnumerator()
        {
            return  this;
        }

        public bool MoveNext()
        {
            if (position < months.Length - 1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object? Current => months[position];

        public void Add(Month month)
        {
            if (months != null)
            {
                Month[] newMonthses = new Month[months.Length + 1];
                for (int i = 0; i < months.Length; i++)
                {
                    newMonthses[i] = months[i];
                }

                newMonthses[^1] = month;
                months = newMonthses;
            }
            else
                months = new[] {month};
        }

        public void Show()
        {
            foreach (var t in months)
            {
                t.Show();
            }
        }

        public Month GetMonthByN(int n)
        {
            return months[n - 1];
        }

        //public void GetMonthByDays(int days) //вариант 1
        //{
        //    var m = from month in months
        //            where month.DaysInMonth == days
        //            select month;

        //    foreach (var i in m)
        //    {
        //        i.Show();
        //    }
        //}

        public IEnumerable GetMonthByDays(int days) //вариант 2
        {
             var m = from month in months
                where month.DaysInMonth == days
                select month;

             return m;
        }
    }
}
