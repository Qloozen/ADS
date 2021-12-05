using System;

namespace Huiswerk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isPalindroom("lepel"));
            //Console.WriteLine(maxrec(new int[] {6,3,10,2,1,9,8}));
            //Console.WriteLine(BinarySearch(new int[] {6,3,10,2,1,9,8}, 10, 0, 7));
            //System.Console.WriteLine(CalculateFaculty(5));
            //System.Console.WriteLine(fibo(10));
            hanoi(4, 'A', 'B', 'C');
        }

        // Opdracht 1
        public static bool isPalindroom(string s) {
            if(s.Length == 1) {
                return true;
            }

            if(s[0] == s[s.Length-1]) {
                return isPalindroom(s.Substring(1, s.Length-2));
            } else {
                return false;
            }
        }
    
        // Opdracht 2
        public static int maxrec(int[] a) {
            if(a.Length == 1) {
                return a[0];
            }

            int first, second;
            first = a[0];
            second = a[1];

            if(first < second) {
                int[] newArray = new int[a.Length - 1];
                Array.Copy(a, 1, newArray, 0, a.Length -1);

                return maxrec(newArray);
            } else {
                int[] newArray = new int[a.Length - 1];
                newArray[0] = first;
                Array.Copy(a, 2, newArray, 1, a.Length -2);

                return maxrec(newArray);
            }
        }
    
        // Opdracht 3
        public static bool BinarySearch(int[] a, int target, int start, int end) {//?
            int middle = (start + end)/2;

            if(end < start){

                return false;
            }

            if (target < a[middle]){

                return BinarySearch(a, target, start, middle - 1);
            }

            if (target > a[middle]){

                return BinarySearch(a, target, middle + 1, end);
            }

            if (target == a[middle]){

                return true;
            }

            return false;

        }
    

        // Opdracht 1
        public static int CalculateFaculty(int n) {
            if(n <= 0) {
                return 1;
            }

            return n * CalculateFaculty(n-1);
        }
    
        // Opdracht 2
        public static int fibo(int n) {
            if(n <= 2) {
                return 1;
            }
            return fibo(n-1) + fibo(n-2);
        }

        // Opdracht 3
        public static void hanoi(int n, char from, char helper, char target) {
            if(n > 0 ) {
                hanoi (n-1, from, target, helper);
                move(from, target);
                hanoi (n-1, helper, from, target);
            }
        }
        public static void move(char From, char To) {
            System.Console.WriteLine($"Schijf van {From} naar {To}");
        }
    }
}
