using _01.LoggerProblem.Enums;

namespace _01.LoggerProblem.Interfaces
{
    public interface IAppender
    {
        int Count { get; }

        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string timeStamp, string reportLevel, string message);
    }
}
