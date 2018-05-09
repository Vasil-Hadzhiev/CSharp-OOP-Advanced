﻿namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando
    {
        IList<IMission> Missions { get; }

        void CompleteMission();
    }
}