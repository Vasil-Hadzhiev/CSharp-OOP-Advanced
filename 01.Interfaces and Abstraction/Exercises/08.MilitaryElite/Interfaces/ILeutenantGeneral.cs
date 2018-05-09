namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral
    {
        IList<ISoldier> Soldiers { get; }
    }
}