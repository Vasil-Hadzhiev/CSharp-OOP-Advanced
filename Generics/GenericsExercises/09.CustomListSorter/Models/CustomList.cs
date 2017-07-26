using System;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ICustomList<T>
    where T : IComparable<T>
{
    private List<T> elements;

    public CustomList()
    {
        this.Elements = new List<T>();
    }

    public List<T> Elements
    {
        get { return this.elements; }
        set { this.elements = value; }
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public bool Contains(T element)
    {
        return this.elements.Contains(element);
    }

    public int CountGreaterThan(T element)
    {
        return this.elements.Count(e => e.CompareTo(element) > 0);
    }

    public T Max()
    {
        return this.elements.Max();
    }

    public T Min()
    {
        return this.elements.Min();
    }

    public T Remove(int index)
    {
        var elementToReturn = this.elements[index];
        this.elements.RemoveAt(index);

        return elementToReturn;
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.elements[index1];
        this.elements[index1] = this.elements[index2];
        this.elements[index2] = temp;
    }
}

