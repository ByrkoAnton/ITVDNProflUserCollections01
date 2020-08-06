using System;
using System.Collections.Generic;

namespace UserCollectionsAdditional
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = GetPowOdds(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
            //var arr = GetPowOdds(new int[] {2,4,6});

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public static IEnumerable<double> GetPowOdds(int[] arr)
        {
            foreach (var i in arr)
            {
                if (i % 2 != 0)
                    yield return Math.Pow(i, 2);
            }
        }
    }
}
