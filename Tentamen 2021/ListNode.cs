using System;

class ListNode<T> : ICloneable
{
    private ListNode<T> Next;
    private T Data;

    public ListNode(ListNode<T> previous, T data)
    {
        if(previous != null) previous.Next = this;
        Data = data;
    }

    public ListNode(ListNode<T> other) {
        this.Data = other.Data;
        if (other.Next != null) {
            ListNode<T> nextCopy = new ListNode<T>(other.Next);
            this.Next = nextCopy;
        }
    }

    public object Clone()
    {
        return new ListNode<T>(this);
    }

    public void ReplaceAt(int index, T newData) {
        if (index < 0) {
            throw new IndexOutOfRangeException("index does not exist in linked list");
        } else if (index == 0) {
            Data = newData;
        } else {
            Next.ReplaceAt(index - 1, newData);
        }
    }

    public override string ToString()
    {
        if(Next != null) {
            return String.Format("{0}, {1}", Data.ToString(), Next.ToString());
        } else {
            return Data.ToString();
        }
    }
}