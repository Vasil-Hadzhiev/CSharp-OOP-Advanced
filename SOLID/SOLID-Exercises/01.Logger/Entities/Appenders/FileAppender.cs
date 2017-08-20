﻿using _01.LoggerProblem.Interfaces;

namespace _01.LoggerProblem.Entities.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) 
            : base(layout)
        {
            this.File = new LogFile();
        }

        public LogFile File { get; set; }

        public override void Append(string timeStamp, string reportLevel, string message)
        {
            this.Count++;
            var formattedMsg = this.Layout.FormatMessage(timeStamp, reportLevel, message);
            this.File.Write(formattedMsg);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.File.Size}";
        }
    }
}
