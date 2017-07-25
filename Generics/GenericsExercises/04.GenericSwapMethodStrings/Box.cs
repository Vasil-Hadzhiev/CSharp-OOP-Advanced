using System.Collections.Generic;

public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        return $"{value.GetType().FullName}: {this.value}";
    }

    public static void Swap<T>(List<T> elements, int firstIndex, int secondIndex)
    {
        var temp = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[secondIndex] = temp;
    }
}

