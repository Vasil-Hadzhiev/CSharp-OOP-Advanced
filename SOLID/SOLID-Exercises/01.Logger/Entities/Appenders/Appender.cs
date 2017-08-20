using _01.LoggerProblem.Interfaces;
using System.Text;
using _01.LoggerProblem.Enums;

namespace _01.LoggerProblem.Entities.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public int Count { get; protected set; }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string timeStamp, string reportLevel, string message);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Appender type: {this.GetType().Name}, ");
            sb.Append($"Layout type: {this.Layout.GetType().Name}, ");
            sb.Append($"Report level: {this.ReportLevel.ToString().ToUpper()}, ");
            sb.Append($"Message appended: {this.Count}");

            return sb.ToString();
        }
    }
}
