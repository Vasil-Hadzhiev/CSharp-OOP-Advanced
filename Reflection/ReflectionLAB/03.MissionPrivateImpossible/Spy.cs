using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);

        var classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var privateMethod in classPrivateMethods)
        {
            sb.AppendLine($"{privateMethod.Name}");
        }

        return sb.ToString().Trim();
    }
}

