using System;
using System.Collections.Generic;

namespace Hertentamen_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleFactorial(3));
        }

        static long DoubleFactorial(int n) {
            if (n == 0) {
                return 2;
            }
            System.Console.WriteLine("doubleFactorial(" + n + ") called");
            return n * DoubleFactorial(n - 1);
        }
        public static IList<ICollection<E>> SpecialSort<E>(IList<E> l) where E : IComparable<E> {
            ICollection<E> c1 = new List<E>();
            ICollection<E> c2 = new List<E>();
            ICollection<E> c3 = new List<E>();

            foreach(E e in l) {
                
            }

            return new List<ICollection<E>>();
        }
    }
}
