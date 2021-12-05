using System;
using System.Collections.Generic;
using System.Linq;

namespace Tentamen_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(IsRoute(2, 10, 26, 12));
            System.Console.WriteLine(Freq<int>(new List<int>() {12, 12, 8, 8, -3}));
        }

        public static bool IsRoute(int xStart, int yStart, int xEnd, int yEnd) {
            //basic case
            if(xStart > xEnd || yStart > yEnd) {
                return false;
            }
            if(xStart == xEnd && yStart == yEnd) {
                return true;
            }

            return 
                IsRoute((xStart + yStart), yStart, xEnd, yEnd) ||
                IsRoute(xStart, (yStart + xStart), xEnd, yEnd);
        }
    
        private static SortedDictionary<E, int> Freq<E>(IList<E> list) where E : IComparable<E> {

            SortedDictionary<E, int> sorted = new SortedDictionary<E, int>();
            foreach (E item in list)
            {
                if(sorted.ContainsKey(item)) {
                    sorted[item] = sorted[item] + 1;
                } else {
                    sorted.Add(item, 1);
                }            
            }

            return sorted;
        }
    }
}
