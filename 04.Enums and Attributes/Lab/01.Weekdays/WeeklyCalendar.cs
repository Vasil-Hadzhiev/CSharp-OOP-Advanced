﻿namespace _01.Weekdays
{
    using System.Collections.Generic;

    public  class WeeklyCalendar
    {
        private IList<WeeklyEntry> weeklyEntries;

        public WeeklyCalendar()
        {
            this.weeklyEntries = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekday, string notes)
        {
            this.weeklyEntries.Add(new WeeklyEntry(weekday, notes));
        }

        public IEnumerable<WeeklyEntry> WeeklySchedule
        {
            get { return this.weeklyEntries; }
        }
    }
}