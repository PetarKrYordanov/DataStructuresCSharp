using System;
using System.Collections;
using System.Collections.Generic;

public class ReversedList<T> : IEnumerable<T>
{

    private readonly int StartingCapacity = 2;

    private T[] items;
    private int count;
    public ReversedList()
    {
        items = new T[StartingCapacity];
        Count = 0;
    }
   
    public int Count
    {
        get => count;
        private set => count = value;
    }

    public int Capacity => items.Length;

    public T this[int index]
    {
        get
        {
            if (index > Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            return items[Capacity - 1 - index];
        }
        set
        {
            if (index > Count - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            items[Capacity - 1 - index] = value;
        }

    }

    public void Add(T item)
    {
        if (Capacity - 1 == Count)
        {
            MakeTwiceBigger();
        }
        int index = Capacity - 1 - Count;
        items[index] = item;
        Count++;
    }

    private void MakeTwiceBigger()
    {
        T[] copy = new T[items.Length * 2];

        for (int i = 0; i <= items.Length - 1; i++)
        {
            copy[i + items.Length] = items[i];
        }

        items = copy;
    }

    public void RemoveAt(int index)
    {
        if (Count < 0)
        {
            throw new InvalidOperationException("Cannot remove from empty structure");
        }

        if (Count - 1 < index || index < 0)
        {
            throw new InvalidOperationException("Index out of range");
        }

        int indexToRemove = Capacity - 1 - index;
        if (indexToRemove == 0)
        {
            items[0] = default(T);
            Count--;
            return;
        }

        for (int i = indexToRemove; i >= Capacity - Count; i--)
        {
            items[i] = items[i - 1];
        }
        Count--;
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Capacity - Count; i < items.Length; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

