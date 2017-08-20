using System;
using _01.LoggerProblem.Interfaces;

namespace _01.LoggerProblem.Entities.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {         
        }

        public override void Append(string timeStamp, string reportLevel, string message)
        {
            this.Count++;
            var formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            Console.WriteLine(formattedMsg);
        }
    }
}
