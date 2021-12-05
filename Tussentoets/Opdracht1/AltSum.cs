using System;

namespace Opdracht1
{
    class AltSum
    {
        static void Main(string[] args)
        {
            //Alterende som uitrekenen: n - (n-1) + (n-2) - (n-3) - (n-4) ... +/- 0.
            Console.WriteLine(altSum(4));           
        }

        public static int altSum(int n) {
            if(n <= 0) {
                return n;
            }
            
            return n - altSum(n-1);
        }
    }
}
