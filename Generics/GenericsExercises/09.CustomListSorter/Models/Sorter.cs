using System;
using System.Collections.Generic;
using System.Linq;

public class Sorter<T>
    //where T : IComparable<T>
{
    public static List<T> Sort(List<T> customList)
    {
        return customList.OrderBy(e => e).ToList();
    }
}

