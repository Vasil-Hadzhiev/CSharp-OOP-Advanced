using _01.LoggerProblem.Interfaces;

namespace _01.LoggerProblem.Entities.Layout
{
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string timeStamp, string reportLevel, string message)
        {
            return $"{timeStamp} - {reportLevel} - {message}";
        }
    }
}
