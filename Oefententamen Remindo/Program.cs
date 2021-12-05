using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //ExcersizeOne();
        //ExcersizeTwo();
        Console.WriteLine(CalculateGiftedHouses(new int[] {0,1,1,1,1,1,1}));
    }

    public static void ExcersizeOne() {
        // Exersize 1
        Container<int> container = new Container<int>(); // C#

        container.insert(1);
        container.insert(2);
        container.insert(3);
        container.insert(4);
        container.insert(5);

        var firstToBeProcessed = container.pop(); // dit is 1
        var secondToBeProcessed = container.pop(); // dit is 2

        container.insert(1);
        container.insert(5);
        container.insert(5);

        container.pop();

        List<int> smallest = container.smallest(); // dit is [1, 1, 2]

        int mostSequentialPops = container.mostSequentialPops(); // dit is 2 
    }

    public static void ExcersizeTwo() {
        // Excersize 2
		TreeNode twelve = new TreeNode(12, null, null);
		TreeNode seven = new TreeNode(7, twelve, null);
		TreeNode eight = new TreeNode(8, null, null);
		TreeNode five = new TreeNode(5, eight, seven);

		TreeNode three = new TreeNode(3, null, null);
		TreeNode seventeen = new TreeNode(17, null, three);
		TreeNode eleven = new TreeNode(11, null, null);
		TreeNode four = new TreeNode(4, seventeen, eleven);

		TreeNode root = new TreeNode(10, five, four);

		Console.WriteLine(root.SpecialSum()); // geeft 142 terug
    }

    public static int CalculateGiftedHouses(int[] a, int index = 0) {
        int steps3, steps4, steps5, currentHouse;
        
        // Base case
        if(index == a.Length - 1) {
            currentHouse = a[index];
            return currentHouse; // Last jump will be exact on the last house, so check if it has a chimney
        }
        if(index > a.Length -1) {
            return 0; // Last jump will go off the array so 0 houses will get gifts
        } 

        // Make problem smaller by adding current node value + any subtrees
        currentHouse = a[index];
        steps3 = currentHouse + CalculateGiftedHouses(a, index + 3);
        steps4 = currentHouse + CalculateGiftedHouses(a, index + 4);
        steps5 = currentHouse + CalculateGiftedHouses(a, index + 5);

        // Result will check which step is better and returns the total houses with chimneys
        if (steps3 <= steps4 && steps3 <= steps5) {
            return steps3;
        } else if(steps4 <= steps3 && steps4 <= steps5) {
            return steps4;
        } else {
            return steps5;
        }
    }

    public static int CalculateGiftedHousesSecond(int[] a, int index = 0) {
        int steps3, steps4, steps5, currentHouse;
        
        //Base case
        if(index > a.Length -1) {
            return 0; // Last jump will go off the array so 0 houses will get gifts
        } 

        // Make problem smaller by adding current node value + any subtrees
        steps3 = CalculateGiftedHousesSecond(a, index + 3);
        steps4 = CalculateGiftedHousesSecond(a, index + 4);
        steps5 = CalculateGiftedHousesSecond(a, index + 5);

        return a[index] +  Math.Min(steps3, Math.Min(steps4, steps5));
    }
}