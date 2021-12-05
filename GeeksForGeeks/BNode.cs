using System;

class BNode<E> where E : IComparable<E>
{   
    public E Value {get;}
    private BNode<E> LeftChild, RightChild;

    public BNode(E value)
    {
        this.Value = value;
    }

    public void AddNode(E newvalue) {
        BNode<E> childNode = new BNode<E>(newvalue);

        if(newvalue.CompareTo(Value) < 0) {
            if(LeftChild != null) {
                LeftChild.AddNode(newvalue);
            } else {
                LeftChild = childNode;
            }
        } else if(newvalue.CompareTo(Value) > 0) {
            if(RightChild != null) {
                RightChild.AddNode(newvalue);
            } else {
                RightChild = childNode;
            }
        }
    }

    public void PrintLeafNodesLeftToRight() {
        if(LeftChild == null && RightChild == null) {
            System.Console.WriteLine(Value);
        }

        if(LeftChild != null) {
            LeftChild.PrintLeafNodesLeftToRight();
        }

        if(RightChild != null) {
            RightChild.PrintLeafNodesLeftToRight();
        }
    }

}