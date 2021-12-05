using System.Collections.Generic;

class NNode<T>
{
    public List<NNode<T>> Children {get;set;}
    public NNode<T> Parent {get;set;}
    public T Element {get;set;}
    public NNode(T Element)
    {
        this.Element = Element;
        Children = new List<NNode<T>>();
    }

}