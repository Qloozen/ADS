using System;
using System.Collections.Generic;

class Container<T>
{
    private Queue<T> Elements = new Queue<T>();
    private int MostSequentialPops;
    private int SequentialPopsCounter;
    public void insert(T newElement){
        if(SequentialPopsCounter > MostSequentialPops) {
            MostSequentialPops = SequentialPopsCounter;
        }

        SequentialPopsCounter = 0;
        this.Elements.Enqueue(newElement);
    }

    public T pop () {
        SequentialPopsCounter ++;
        return this.Elements.Dequeue();
    }

    public List<T> smallest() {
        List<T> smallest = new List<T>();;
        foreach(T t in Elements) {
            smallest.Add(t);
        }
        smallest.Sort();

        return smallest.GetRange(0, 3);
    }

    public int mostSequentialPops() {
        return this.MostSequentialPops;
    }
}