using System;

namespace GeeksForGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            BNode<int> root = new BNode<int>(10);
            SeedBTree(root);
            root.PrintLeafNodesLeftToRight();
        }

        public static void SeedBTree(BNode<int> root) {
            root.AddNode(7);
            root.AddNode(9);
            root.AddNode(6);
            root.AddNode(8);
            root.AddNode(4);
            root.AddNode(21);
            root.AddNode(12);
            root.AddNode(23);
        }
    }
}
