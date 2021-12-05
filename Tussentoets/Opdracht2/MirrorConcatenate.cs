using System;

namespace Opdracht2
{
    class MirrorConcatenate
    {
        static void Main(string[] args)
        {
            //Spiegelt de string achter de orginele (abcd => abcddcba)
            Console.WriteLine(mirrorConcatenate("abcd"));
        }

        public static string mirrorConcatenate(string s) {
            if(s.Length == 1) return s + s;

            return s[0] + mirrorConcatenate(s.Substring(1, s.Length -1)) + s[0];
        }
    }
}
