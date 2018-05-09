namespace _04.Telephony
{
    using System.Collections.Generic;

    public interface IBrowseable
    {
        ICollection<string> Urls { get; }
        string Browse(string url);
    }
}