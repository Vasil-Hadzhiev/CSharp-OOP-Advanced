using System;

namespace _01.Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private WeekDay weekDay;
        private string notes;

        public WeeklyEntry(string weekDay, string notes)
        {
            this.weekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekDay);
            this.notes = notes;
        }

        public int CompareTo(WeeklyEntry otherDay)
        {
            var result = this.weekDay.CompareTo(otherDay.weekDay);

            if (result == 0)
            {
                result = this.notes.CompareTo(otherDay.notes);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.weekDay} - {this.notes}";
        }
    }
}
