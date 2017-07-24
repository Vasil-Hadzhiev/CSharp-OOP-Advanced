using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps, IList<IRepair> repairParts) 
        : base(id, firstName, lastName, salary, corps)
    {
        this.RepairParts = repairParts;
    }

    public IList<IRepair> RepairParts { get; }

    public override string ToString()
    {
        var sb = new StringBuilder(base.ToString());

        sb.AppendLine("Repairs:");
        sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.RepairParts)}");

        return sb.ToString().Trim();
    }
}

