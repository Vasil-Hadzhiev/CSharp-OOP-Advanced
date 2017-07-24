using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, IList<ISoldier> privates) 
        : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public IList<ISoldier> Privates { get; }

    public override string ToString()
    {
        var sb = new StringBuilder(base.ToString());

        sb.AppendLine();
        sb.AppendLine("Privates:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");

        return sb.ToString().Trim();
    }
}

