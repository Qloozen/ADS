using System;

namespace Recursie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Qiang"));
        }

        static string ReverseString(string s) {
            // Basic case
            if(s.Length == 1 || s.Length == 0) {
                return s;
            }

            // Make problem a bit smaller "g" + ReverseString(qian)
            return s[s.Length-1] + ReverseString(s.Substring(0, s.Length - 1));
        }
    }
}
