using System;

public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int code)
        : base(id, firstName, lastName)
    {
        this.Code = code;
    }

    public int Code { get; }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"Code Number: {this.Code}";
    }
}

