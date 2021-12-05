using System;

namespace Lesoefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            BNode<int> root = new BNode<int>(5);
            root.Insert(3);
            root.Insert(4);
            root.Insert(8);

            root.Print();
        }
    }
}
