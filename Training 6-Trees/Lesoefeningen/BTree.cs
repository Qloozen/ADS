using System;
using System.Collections.Generic;
using System.Text;

public class BNode<T> where T : IComparable<T> { //IComparable als boundary, omdat je bij het inserten moet kijken of T < of > of gelijk is
    public T element {get; set;}
    private BNode<T> leftChild;
    private BNode<T> rightChild;

    public BNode(T element)
    {
        this.element = element;
    }

    public void Insert(T newElement) {
        if (newElement.CompareTo(this.element) < 0) {
            if(leftChild == null) {
                leftChild = new BNode<T>(newElement);
            } else {
                leftChild.Insert(newElement);
            }
        } else if (newElement.CompareTo(this.element) > 0) {
            if(rightChild == null) {
                rightChild = new BNode<T>(newElement);
            } else {
                rightChild.Insert(newElement);
            }
        }
    }

    //Boom uitprinten naar console (Pre-, In-, Post-order)
    public void Print() {

        if(leftChild != null) { // Linker sub-tree
            leftChild.Print();
        }

        Console.WriteLine(element); // Huidige node (pre, in, post: staat nu in-order)

        if(rightChild != null) { // Rechter sub-tree
            rightChild.Print();
        }
    }

    //Boom level-order uitprinten
    public void PrintLevelOrder() {
        Queue<BNode<T>> queue = new Queue<BNode<T>>();

        while(queue.Count > 0) {
            BNode<T> parent = queue.Dequeue();
            Console.WriteLine(parent.element);
            if(parent.leftChild != null) queue.Enqueue(parent.leftChild);
            if(parent.rightChild != null) queue.Enqueue(parent.rightChild);
        }
    }

    //Boom gesorteerd uitprinten met behulp van een helper methode 
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        BuildString(sb);

        return sb.ToString();
    }

    public void BuildString(StringBuilder sb) {
        if(leftChild != null) { // Linker sub-tree
            leftChild.BuildString(sb);
        }

        sb.Append(this.element); // Huidige node (pre, in, post: staat nu in-order)

        if(rightChild != null) { // Rechter sub-tree
            rightChild.BuildString(sb);
        }
    }
}
